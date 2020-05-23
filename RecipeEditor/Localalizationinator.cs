//TODO: try to make this work eventually
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;
using System.ComponentModel.Design;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Drawing;

namespace RecipeEditor
{
    // BEHOLD, MY
    class Localization//INATOR
    {
        static Dictionary<String, String> localizationDictionary = new Dictionary<String, String>();
        static Dictionary<String, String> externalizationDictionary = new Dictionary<String, String>();
        public static String lang = CultureInfo.GetCultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName).EnglishName.ToLower();
        public static void Load()
        {
            // put the current language file in languagedocument
            JObject languagesjson = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Form1.SmPath + "Data\\Gui\\Language\\languages.json"));
            JObject languagedocument;
            if (!languagesjson.ContainsKey(lang))
                languagedocument = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Form1.SmPath + "Data\\Gui\\Language\\English\\InventoryItemDescriotions.json"));
            else
                languagedocument = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Form1.SmPath + "Data\\Gui\\Language\\" + languagesjson[lang] + "\\InventoryItemDescriptions.json"));
            JObject survivaldoc = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Form1.SmPath + "Survival\\Gui\\Language\\English\\inventoryDescriptions.json"));
            languagedocument.Merge(survivaldoc);
            // oh cool, dictionaries
            List<String> forthefor = DataClass.ItemDictionary.Keys.ToList();
            foreach (String key in forthefor)
            {
                Debug.Print($"{key}:{DataClass.ItemDictionary[key]}");
                try
                {
                    if (!localizationDictionary.ContainsKey(key))
                        localizationDictionary.Add(key, languagedocument[key]["title"].ToString());
                    if (!externalizationDictionary.Keys.Contains(key))
                        externalizationDictionary.Add(languagedocument[key]["title"].ToString(), key);
                }
                catch
                {
                    Debug.Print("bruh"); //TODO: fix duplicate BS
                }
            }
        }


        // Item list localization
        public static List<String> Localize(List<String> inputList)
        // Feed item GUIDs
        {
            List<String> outputList = inputList;
            inputList.ForEach(a => a = localizationDictionary[a]);
            return outputList;
        }
        public static String Localize(string input)
        {
            try
            {
                return localizationDictionary[input];
            }
            catch
            {
                return input;
            }
        }
        public static String Externalize(string input)
        {
            try
            {
                return externalizationDictionary[input];
            }
            catch
            {
                return input;
            }
        }

        public static List<String> LocalizeList(List<String> input)
        {
            try
            {
                List<String> returner = new List<String>();
                foreach(String streeng in input)
                {
                    returner.Add(localizationDictionary[streeng]);
                }
                return returner;
            }
            catch
            {
                return input;
            }
        }
        public static List<String> ExternalizeList(List<String> input)
        {
            try
            {
                List<String> returner = new List<String>();
                foreach (String streeng in input)
                {
                    returner.Add(externalizationDictionary[streeng]);
                }
                return returner;
            }
            catch
            {
                return input;
            }
        }
    }
}

