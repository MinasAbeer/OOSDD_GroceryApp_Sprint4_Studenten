namespace Grocery.Core.Models
{
    public class BoughtProductEntry
    {
        public Client Client { get; set; } = null!;
        public GroceryList GroceryList { get; set; } = null!;
        public GroceryListItem GroceryListItem { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
