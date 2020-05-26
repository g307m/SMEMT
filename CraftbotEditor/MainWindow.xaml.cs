using CraftbotEditor.Properties;
using HelixToolkit.Wpf;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CraftbotEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ImageSource CraftbotMainBG;
        public MainWindow()
        {
            InitializeComponent();
            // Loading data
            GameData.Load();
            localization = new Localization();
            MainBackgroundImage.Source = GameData.MainBackground;
            TooltipBackgroundImage.Source = GameData.TooltipBackground;
            RecipeItems.ItemsSource = GameData.RecipeList;
            // recipe loading
            foreach (Recipe recipe in GameData.WorkstationDocument)
            {
                {
                    RecipeButtonControl recipeButtonControl = new RecipeButtonControl(recipe);
                    if (!GameData.RecipeList.Contains(recipeButtonControl))
                        GameData.RecipeList.Add(recipeButtonControl);
                }
            }
            GameData.RecipeList.ForEach(a => a.off());
            GameData.RecipeList[0].on();

            // stuff
            ItemViewport.ItemSheet.Source = GameData.ItemMap;
        }
        Localization localization;
        public void ShowRecipe(String itemId)
        {
            Debug.Print("Showing recipe for " + itemId + $"({localization.GetBaseName(itemId)})");
            if (localization.ItemDescriptions[itemId]["title"] != null)
                RecipeItemLabel.Text = localization.ItemDescriptions[itemId]["title"].ToString();
            if (localization.ItemDescriptions[itemId]["description"] != null)
                Descripton.Text = localization.ItemDescriptions[itemId]["description"].ToString();
            ItemViewport.ItemSheet.Margin = ItemMapMargin.itemThickness(itemId);
        }

        private void AddRemoveRecipe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
