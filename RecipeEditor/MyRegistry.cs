using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEditor
{
    class MyRegistry
    {
        // Declarations
        public static RegistryKey Key;
        // Functions
        // Puts the registry together so it's nice and usable.
        static void BuildRegistry()
        {
            Key.SetValue("IsBackupped", false);
        }
        public static void Startup()
        {
            if (!Registry.CurrentUser.GetSubKeyNames().Contains("Software\\SMEMT"))
            {
                Key = Registry.CurrentUser.CreateSubKey("Software\\SMEMT");
                BuildRegistry();
            }
            else
            {
                Key = Registry.CurrentUser.OpenSubKey("Software\\SMEMT");
                if (Key.GetValue("IsBackupped")==null)
                    BuildRegistry();
            }
                
        }

        // Fun
        /*public static bool IsBackupped
        {
            get { return (bool)Key.GetValue("IsBackupped"); }
            set { Key.SetValue("IsBackupped", (bool)value); }
        }*/
    }
}
