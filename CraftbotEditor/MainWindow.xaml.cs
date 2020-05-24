using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
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
            // Style
            
            // Loading data
            GameData.Load();
            MainBackgroundImage.Source   = GameData.MainBackground;

            // Event stuff
            //MainBackgroundImage.MouseDown += Mbi_MouseDown;
            
        }

        // Dragging
        private void Mbi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
