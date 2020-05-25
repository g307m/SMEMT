using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Xml;

namespace CraftbotEditor
{
    class GoodImage
    {
        public static BitmapImage FromFile(String path)
        {
            return FromFile(new Uri(path));
        }
        public static BitmapImage FromFile(Uri uri)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = uri;
            image.EndInit();
            return image;
        }
    }
    class ItemMapMargin
    {
        public static XmlDocument itemXml = new XmlDocument();
        public static Thickness itemThickness(String itemId)
        {
            Thickness thickness = new Thickness(0, -838, -4500, -3035);
            // -horizontal, -vertical
            foreach(XmlNode child in itemXml.SelectSingleNode("MyGUI/Resource").SelectNodes("Group/*"))
            {
                Debug.Print(child.Attributes["name"].Value.ToString());
                if(child.Attributes["name"].Value.ToString()==itemId)
                {
                    XmlNode Frame = child.SelectSingleNode("Frame");
                    Debug.Print(Frame.Attributes["point"].Value.ToString().Split(' ')[0] + " " + Frame.Attributes["point"].Value.ToString().Split(' ')[1]);
                    Double h = Double.Parse(Frame.Attributes["point"].Value.ToString().Split(' ')[0]);
                    Double v = Double.Parse(Frame.Attributes["point"].Value.ToString().Split(' ')[1]);
                    h = (h / 96) * 108; // Some math to have it match up nicely
                    v = (v / 96) * 108;
                    thickness.Left = thickness.Left-h;
                    thickness.Top = thickness.Top-v;
                    thickness.Right = thickness.Right + h;
                    thickness.Bottom = thickness.Bottom + v;
                    Debug.Print(thickness.ToString());
                    break;
                }
            }
            return thickness;
        }
    }
}
