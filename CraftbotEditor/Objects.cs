using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftbotEditor
{
    public class Item
    {
        private String ItemId;
        public int quantity = 1;
        public String itemId
        {
            get { return ItemId;}
            set { OnItemChanged(EventArgs.Empty); ItemId = value; }
        }
        public Item() { }
        public Item(String itemId)
        {
            this.ItemId = itemId;
        }
        // pretty much just for icon changing
        public event EventHandler ItemChanged;
        protected virtual void OnItemChanged(EventArgs e)
        {
            EventHandler handler = ItemChanged;
            handler?.Invoke(this, e);
        }
    }
    public class Recipe : Item
    {
        public int craftTime = 2;
        public List<Item> ingredientList = new List<Item>();
        public Recipe(String itemId)
        {
            this.itemId = itemId;
        }
    }
}
