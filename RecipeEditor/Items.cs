using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeEditor
{
    class Item
    {
        public uint quantity;
        public String itemId;
        public Item(String itemId, uint quantity = 1)
        {
            this.itemId = itemId;
            this.quantity = quantity;
        }
    }
}
