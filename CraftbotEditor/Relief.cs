using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

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
}
