using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftbotEditor
{
    class Item
    {
        public String itemId;
        public int quantity = 1;
        public int craftTime = 2;
        public Item(String itemId)
        {
            this.itemId = itemId;
        }
    }
    class Recipe
    {
        Item product;
        List<Item> ingredientList = new List<Item>();
        public Recipe(String itemId)
        {
            product = new Item(itemId);
        }
    }
}
