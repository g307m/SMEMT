using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEditor
{
    class Recipe
    {
        public String itemId;
        public uint quantity;
        public uint craftTime;
        public List<Item> ingredientList;
        public void AddIngredient(String name)
        {
            this.ingredientList.Add(new Item(Form1.ItemDictionaryReversed[name]));
        }
        public Recipe(String itemId, uint quantity = 1,uint craftTime=0)
        {
            this.itemId = itemId;
            this.quantity = quantity;
            this.craftTime = craftTime;
            this.ingredientList = new List<Item>();
        }
    }
}
