using System;

using BrainFoodFriday.Models;

namespace BrainFoodFriday.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;

            // Some comment goes here
        }
    }
}
