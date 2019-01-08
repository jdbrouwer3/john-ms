using System;
using System.Collections.Generic;

namespace PizzaStore.Data
{
    public partial class Ingredient
    {
        public int IngredientId { get; set; }
        public byte? InventoryId { get; set; }
        public string Name { get; set; }

        public virtual Location Inventory { get; set; }
    }
}
