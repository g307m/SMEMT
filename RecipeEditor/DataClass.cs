using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEditor
{
    static class DataClass
    {
        public static Dictionary<String, String> ItemDictionary;          // Reading
        public static Dictionary<String, String> ItemDictionaryReversed;  // Writing
        public static void ItemDictInit()
        {
            String item_names = File.ReadAllText(Form1.CraftingPath + "item_names.json");
            DataClass.ItemDictionary = JsonConvert.DeserializeObject<Dictionary<String, String>>(item_names);
            DataClass.ItemDictionaryReversed = DataClass.ItemDictionary.ToDictionary(x => x.Value, x => x.Key);
        }
    }
}
