using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CraftbotEditor
{
    /// <summary>
    /// Interaction logic for RecicpeButtonControl.xaml
    /// </summary>
    public partial class RecipeButtonControl : UserControl
    {
        public Item displayedProduct;
        bool selected = false;
        public void toggle()
        {
            if (selected)
                off();
            else
                on();
        }
        public void on()
        {
            RecipeNormalImage.Visibility = Visibility.Hidden;
            RecipeSelectedImage.Visibility = Visibility.Visible;
            MainWindow.ShowRecipe(displayedProduct.itemId);
        }
        public void off()
        {
            RecipeNormalImage.Visibility = Visibility.Visible;
            RecipeSelectedImage.Visibility = Visibility.Hidden;
        }
        public RecipeButtonControl(Item item)
        {
            InitializeComponent();
            displayedProduct = item;
            this.ItemImage.Margin = ItemMapMargin.itemThickness(item.itemId);
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        void DelegateMethod()
        {
            RecipeNormalImage.Visibility = Visibility.Visible;
            RecipeSelectedImage.Visibility = Visibility.Hidden;
        }
        static event EventHandler ItemChanged;
        protected virtual void OnItemChanged(EventArgs e)
        {
            EventHandler handler = ItemChanged;
            handler?.Invoke(this, e);
        }
        private void SelectionButton_Click(object sender, RoutedEventArgs e)
        {
            GameData.RecipeList.ForEach(a => a.off());
            on();
        }
    }
}
