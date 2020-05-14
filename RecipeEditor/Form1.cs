using Gameloop.Vdf;
using Gameloop.Vdf.JsonConverter;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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
            bool IsBackupped = (string)MyRegistry.Key.GetValue("IsBackupped")=="True"?true:false;
            if (!IsBackupped)
            {
                Debug.Print("Backup not set!");
                Directory.CreateDirectory(SmemtData + "RecipeEditor");
                if(!File.Exists(SmemtData + "RecipeEditor\\craftbot.json"))
                    File.Copy(CraftingPath+"craftbot.json", SmemtData+"RecipeEditor\\craftbot.json");
                Debug.Print("Copied 'craftbot.json'");
                MyRegistry.Key.SetValue("IsBackupped",true);
                Debug.Print("Backed up craftbot.json"); 
            }
        }
        Dictionary<String, String> ItemDictionary;          // Reading
        Dictionary<String, String> ItemDictionaryReversed;  // Writing
        void LoadCraftbot() // Loads item_names.json into ItemBox, and craftbot.json into RecipeBox
        {
            String item_names = File.ReadAllText(CraftingPath + "item_names.json");
            ItemDictionary = JsonConvert.DeserializeObject<Dictionary<String, String>>(item_names);
            ItemDictionaryReversed = ItemDictionary.ToDictionary(x => x.Value, x => x.Key);
            ItemBox.DataSource = ItemDictionary.Values.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyRegistry.Startup();
            GetCraftbotPath();
            CraftbotBackup();
            LoadCraftbot();
        }
        // The two boxes are literally the same.
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if (!RecipeBox.Items.Contains(ItemBox.SelectedItem))
                RecipeBox.Items.Add(ItemBox.SelectedItem);
        }

        private void DelRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeBox.Items.Remove(RecipeBox.SelectedItem);
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            if (!IngredientBox.Items.Contains(ItemBox.SelectedItem))
                IngredientBox.Items.Add(ItemBox.SelectedItem);
        }

        private void DelIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientBox.Items.Remove(IngredientBox.SelectedItem);
        }
    }
}
