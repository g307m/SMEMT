using Gameloop.Vdf;
using Gameloop.Vdf.JsonConverter;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Can I just say how incredibly hard it is to separate this out into multiple files for me?
namespace RecipeEditor
{
    public partial class Form1 : Form
    {
        String AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        String SmemtData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SMEMT\\";
        public Form1()
        {
            InitializeComponent();
        }
        String SteamInstallPath;
        String CraftingPath;
        void GetCraftbotPath()
        {
            // Get Steam location from registry
            SteamInstallPath = (String)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", "NOT FOUND");
            Debug.Print("SteamPath: \"{0}\"", SteamInstallPath);
            if (SteamInstallPath == "NOT FOUND")
            {   // pierissy bad
                MessageBox.Show("Failed to find Steam install path in registry. Do you have a legitimate copy of the game?", "Failed to find Steam!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            // Turning VDF into JSON, because it's not possible to select the "1" key with VDF
            dynamic libraryfoldersjson = VdfConvert.Deserialize(File.ReadAllText(SteamInstallPath + "\\steamapps\\libraryfolders.vdf")).Value.ToJson();
            if (File.Exists(SteamInstallPath + "\\steamapps\\appmanifest_387990.acf"))
            {
                CraftingPath = SteamInstallPath + "\\steamapps\\common\\Scrap Mechanic\\Survival\\CraftingRecipes\\";
            }
            else
            {
                CraftingPath = libraryfoldersjson.Value<String>("1") + "\\steamapps\\common\\Scrap Mechanic\\Survival\\CraftingRecipes\\";
            }

            Debug.Print("Registered steam: " + SteamInstallPath);
            Debug.Print("Game Path:        " + CraftingPath);

        }
        void CraftbotBackup()
        {
            // Backup chunk
            if (!File.Exists(SmemtData + "\\RecipeEditor\\IsBackupped.txt") ||File.ReadAllText(SmemtData+"\\RecipeEditor\\IsBackupped.txt")=="false")
            {
                Debug.Print("Backup not set!");
                Directory.CreateDirectory(SmemtData + "RecipeEditor");
                if(!File.Exists(SmemtData + "RecipeEditor\\craftbot.json"))
                    File.Copy(CraftingPath+"craftbot.json", SmemtData+"RecipeEditor\\craftbot.json");
                Debug.Print("Copied 'craftbot.json'");
                File.WriteAllText(SmemtData + "\\RecipeEditor\\IsBackupped.txt", "true");
                Debug.Print("Backed up craftbot.json");
            }
        }
        public static Dictionary<String, String> ItemDictionary;          // Reading
        public static Dictionary<String, String> ItemDictionaryReversed;  // Writing
        List<Recipe> CraftbotDocument;
        void LoadCraftbot() // Loads item_names.json into ItemBox, and craftbot.json into RecipeBox
        {
            String item_names = File.ReadAllText(CraftingPath + "item_names.json");
            ItemDictionary = JsonConvert.DeserializeObject<Dictionary<String, String>>(item_names);
            ItemDictionaryReversed = ItemDictionary.ToDictionary(x => x.Value, x => x.Key);
            ItemBox.DataSource = ItemDictionary.Values.ToList();
            dynamic CraftbotJson = JsonConvert.DeserializeObject<List<Recipe>>(File.ReadAllText(CraftingPath + "craftbot.json"));
            CraftbotDocument = CraftbotJson;
            foreach(Recipe r in CraftbotDocument)
            {
                RecipeBox.Items.Add(ItemDictionary[r.itemId]);
            }
            RecipeBox.SetSelected(0,true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //MyRegistry.Startup();
            GetCraftbotPath();
            CraftbotBackup();//broken
            LoadCraftbot();
        }
        bool Save = true;
        private void Form1_FormClosing(object sender, CancelEventArgs e)
        {
            //MyRegistry.Key.Close();
            if (Save)
                File.WriteAllText(CraftingPath+"craftbot.json","//Generated using SMEMT v0.1.0\n"+JsonConvert.SerializeObject(CraftbotDocument,Formatting.Indented));
        }
        // The two boxes are literally the same.
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if (!RecipeBox.Items.Contains(ItemBox.SelectedItem))
            {
                RecipeBox.Items.Add(ItemBox.SelectedItem);
                CraftbotDocument.Add(new Recipe(ItemDictionaryReversed[ItemBox.SelectedItem.ToString()]));
            }
        }

        private void DelRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeBox.Items.Remove(RecipeBox.SelectedItem);
            RecipeBox.SelectedIndex = RecipeBox.Items.Count - 1;
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            if (!IngredientBox.Items.Contains(ItemBox.SelectedItem))
            {
                IngredientBox.Items.Add(ItemBox.SelectedItem);
                CraftbotDocument[RecipeBox.SelectedIndex].AddIngredient(ItemBox.SelectedItem.ToString());
            }
        }

        private void DelIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientBox.Items.Remove(IngredientBox.SelectedItem);
            IngredientBox.SelectedIndex = IngredientBox.Items.Count - 1;
        }

        private void RecipeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ingredients
            IngredientBox.Items.Clear();
            if (RecipeBox.SelectedIndex < 0)
                RecipeBox.SelectedIndex = 1;
            foreach (Item i in CraftbotDocument[RecipeBox.SelectedIndex].ingredientList)
                IngredientBox.Items.Add(ItemDictionary[i.itemId]);
            if(IngredientBox.Items.Count != 0)
                IngredientBox.SetSelected(0, false);
            TimeUD.Value = CraftbotDocument[RecipeBox.SelectedIndex].craftTime;
            // product
            ProductQuantityUD.Value = CraftbotDocument[RecipeBox.SelectedIndex].quantity;
        }

        private void IngredientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                QuantityUD.Value = CraftbotDocument[RecipeBox.SelectedIndex].ingredientList[IngredientBox.SelectedIndex].quantity;
            }
            catch(Exception ex) { }
            ProductQuantityUD.Value = CraftbotDocument[RecipeBox.SelectedIndex].quantity;
        }

        private void QuantityUD_ValueChanged(object sender, EventArgs e)
        {
            CraftbotDocument[RecipeBox.SelectedIndex].ingredientList[IngredientBox.SelectedIndex].quantity = (uint)QuantityUD.Value;
        }

        private void TimeUD_ValueChanged(object sender, EventArgs e)
        {
            CraftbotDocument[RecipeBox.SelectedIndex].craftTime = (uint)TimeUD.Value;
        }

        private void ProductQuantityUD_ValueChanged(object sender, EventArgs e)
        {
            CraftbotDocument[RecipeBox.SelectedIndex].quantity = (uint)ProductQuantityUD.Value;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            Save = false;
            File.Copy(SmemtData + "RecipeEditor\\craftbot.json", CraftingPath + "craftbot.json", true);
            File.WriteAllText(SmemtData + "\\RecipeEditor\\IsBackupped.txt", "true");
            MessageBox.Show("Restored craftbot.json");
            Application.Exit();
        }
    }
}
