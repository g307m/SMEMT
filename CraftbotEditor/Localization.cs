using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftbotEditor
{
    /// <summary>
    /// Localization class, currently/temporarily only loads English locale.
    /// </summary>
    class Localization
    {
        /// <summary>
        /// ItemDescriptions[itemId]["title"] returns name of an item from the itemId
        /// </summary>
        public JObject ItemDescriptions;
        public Localization()
        {
            // Load descriptions
            JObject CreativeItemDescriptions = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(GameData.DataPath + "\\Gui\\Language\\English\\inventoryItemDescriptions.json"));
            ItemDescriptions = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(GameData.SurvivalPath + "\\Gui\\Language\\English\\inventoryDescriptions.json"));
            ItemDescriptions.Merge(CreativeItemDescriptions);
        }
        /// <summary>
        /// Gets the base name from an item's UUID
        /// </summary>
        /// <param name="itemId">UUID of item to get base name of</param>
        /// <returns>Base name string from item ID</returns>
        /// Maybe useless?
        public String GetBaseName(String itemId) => GameData.item_names[itemId];
    }
}
