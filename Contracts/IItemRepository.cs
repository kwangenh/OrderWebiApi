using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IItemRepository
    {
        public List<Item> GetItems();
        public Item GetItem(int itemId);
        public Item CreateItem(Item thisItem);
        public Item DeleteItem(int itemId);
        public Item EditItem(Item thisItem);
    }
}
