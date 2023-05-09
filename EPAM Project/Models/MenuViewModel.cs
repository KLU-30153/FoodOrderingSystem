using System.Collections.Generic;
using EPAM_Project.Models;

namespace EPAM_Project.Views.Home
{
    public class MenuViewModel
    {
        public List<Item> Items { get; set; }

        public MenuViewModel()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Item item in Items)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
    }
}
