using Gameloop.Vdf;
using Gameloop.Vdf.JsonConverter;
using Gameloop.Vdf.Linq;
using Microsoft.Win32;
using Newtonsoft.Json;
using RecipeEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
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
    void ShowDebug()
    {
      debugPanel.Controls["cultureLabel"].Text = "2 letter: " + CultureInfo.CurrentCulture.TwoLetterISOLanguageName; // Thanks, Brazil
      debugPanel.Controls["englishDebugLabel"].Text = "english: " + Localization.lang;
      debugPanel.Show();
    }
    public Form1()
    {
      InitializeComponent();
      if (Resources.Deboolg == "true") ShowDebug();
      this.openFileDialog1.Filter = "JSON files (*.json)|*.json";
    }
    String SteamInstallPath;
    public static String CraftingPath;
    void SteamError(String error) // pierissy bad
    {
      Debug.Print("SteamError "+error);
      MessageBox.Show("Failed to find a valid Steam install in the registry/filesystem. Do you have a legitimate copy of the game?", "Failed to find Steam!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      Application.Exit();
    }
    void GetCraftbotPath()
    {
      // Get Steam location from registry
      SteamInstallPath = (String)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", "NOT FOUND");
      Debug.Print("SteamPath: \"{0}\"", SteamInstallPath);
      if (!Directory.Exists(SteamInstallPath))
        SteamError("path not found "+SteamInstallPath);
      // Turning VDF into JSON, because it's not possible to select the "1" key with VDF
      // Unique case worth fixing:
      // TODO: Fix exception when installation on external drive is disconnected
      dynamic libraryfoldersjson = new VProperty();
      try
      {
        libraryfoldersjson = VdfConvert.Deserialize(File.ReadAllText(SteamInstallPath + "\\steamapps\\libraryfolders.vdf")).Value.ToJson();
      }
      catch
      {
        Debug.Print("library folders error");
      }
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
      SmPath = SteamInstallPath + "\\steamapps\\common\\Scrap Mechanic\\";
    }
    public static String SmPath;
    void CraftbotBackup()
    {
      // Backup chunk
      if (!File.Exists(SmemtData + "\\RecipeEditor\\IsBackupped.txt") || File.ReadAllText(SmemtData + "\\RecipeEditor\\IsBackupped.txt") == "false")
      {
        Debug.Print("Backup not set!");
        Directory.CreateDirectory(SmemtData + "RecipeEditor");
        if (!File.Exists(SmemtData + "RecipeEditor\\craftbot.json"))
          File.Copy(CraftingPath + "craftbot.json", SmemtData + "RecipeEditor\\craftbot.json");
        Debug.Print("Copied 'craftbot.json'");
        File.WriteAllText(SmemtData + "\\RecipeEditor\\IsBackupped.txt", "true");
        Debug.Print("Backed up craftbot.json");
      }
    }
    List<Recipe> CraftbotDocument;
    void LoadCraftbot()
    {
      LoadCraftbot(CraftingPath + "craftbot.json");
    }
    void LoadCraftbot(String path) // Loads item_names.json into ItemBox, and craftbot.json into RecipeBox
    {
      FullPath = path;
      FileName = FullPath.Split('\\').Last();
      Text = "SMEMT v"+Resources.VersionString+": Recipe Editor: " + FileName;
      RecipeBox.Items.Clear();
      foreach(String thing in Localization.LocalizeList(DataClass.ItemDictionary.Keys.ToList()))
      {
        ItemBox.Items.Add(thing);
      }
      dynamic CraftbotJson = JsonConvert.DeserializeObject<List<Recipe>>(File.ReadAllText(path));
      CraftbotDocument = CraftbotJson;
      foreach (Recipe r in CraftbotDocument)
      {
        RecipeBox.Items.Add(Localization.Localize(r.itemId.ToString()));
      }
      RecipeBox.SetSelected(0, true);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = $"SMEMT v{Resources.VersionString}: Recipe Editor";
      //MyRegistry.Startup();
      GetCraftbotPath();
      CraftbotBackup();//broken
      DataClass.ItemDictInit();
      Localization.Load();
      LoadCraftbot();
    }
    bool Save = true;
    private void Form1_FormClosing(object sender, CancelEventArgs e)
    {
      //MyRegistry.Key.Close();
      Settings.Default.Save();
      if (Save)
        SaveNow();
    }
    private void SaveNow()
    {
      File.WriteAllText(FullPath, $"//Generated using SMEMT v{Resources.VersionString}\n" + JsonConvert.SerializeObject(CraftbotDocument, Formatting.Indented));
      Debug.Print("saving");
    }
    // The two boxes are literally the same.
    private void AddRecipeButton_Click(object sender, EventArgs e)
    {
      if (!RecipeBox.Items.Contains(ItemBox.SelectedItem))
      {
        RecipeBox.Items.Add(ItemBox.SelectedItem);
        CraftbotDocument.Add(new Recipe(Localization.Externalize(ItemBox.SelectedItem.ToString())));
      }
    }

    private void DelRecipeButton_Click(object sender, EventArgs e)
    {
      CraftbotDocument.Remove(new Recipe(Localization.Externalize(ItemBox.SelectedItem.ToString())));
      RecipeBox.Items.Remove(RecipeBox.SelectedItem);
      RecipeBox.SelectedIndex = RecipeBox.Items.Count - 1;
    }

    private void AddIngredientButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (!IngredientBox.Items.Contains(ItemBox.SelectedItem))
        {
          IngredientBox.Items.Add(ItemBox.SelectedItem);
          CraftbotDocument[RecipeBox.SelectedIndex].AddIngredientID(Localization.Externalize(ItemBox.SelectedItem.ToString()));
        }
      }
      catch
      {
        Debug.Print("ew");
      }
    }

    private void DelIngredientButton_Click(object sender, EventArgs e)
    {
      CraftbotDocument[RecipeBox.SelectedIndex].RemoveIngredient(IngredientBox.SelectedItem.ToString());
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
        IngredientBox.Items.Add(Localization.Localize(i.itemId));
      if (IngredientBox.Items.Count != 0)
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
      catch { }
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

    private void SaveCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      Save = !Save;
    }

    private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new LanguageForm().Show(this);
    }

    private void StripFileSave_Click(object sender, EventArgs e)
    {
      SaveNow();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      CraftingPath = openFileDialog1.FileName;
      FullPath = CraftingPath.Substring(CraftingPath.IndexOf('\\'));
      LoadCraftbot(openFileDialog1.FileName);
    }
    String FullPath;
    String FileName;
    private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
      SaveNow();
    }
  }
}
