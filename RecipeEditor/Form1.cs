using Gameloop.Vdf;
using Gameloop.Vdf.JsonConverter;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RecipeEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String SteamInstallPath;
        String CraftbotPath;
        dynamic libraryfoldersjson;
        void LoadRecipeFile()
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
            var libraryfoldersjson = VdfConvert.Deserialize(File.ReadAllText(SteamInstallPath + "\\steamapps\\libraryfolders.vdf")).Value.ToJson();
            if (File.Exists(SteamInstallPath + "\\steamapps\\appmanifest_387990.acf"))
            {
                CraftbotPath = SteamInstallPath + "\\steamapps\\common\\Scrap Mechanic\\Survival\\CraftingRecipes\\craftbot.json";
            }
            else
            {
                CraftbotPath = libraryfoldersjson.Value<String>("1") + "\\steamapps\\common\\Scrap Mechanic\\Survival\\CraftingRecipes\\craftbot.json";
            }

            Debug.Print("Registered steam: " + SteamInstallPath);
            Debug.Print("Craftbot Path:    " + CraftbotPath);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecipeFile();

        }
    }
}
