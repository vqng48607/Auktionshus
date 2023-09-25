using AuktionhusServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuktionhusServer.Controller
{
    internal class ItemController
    {
        public void Create(string name, decimal minimunPrice, decimal salesPrice)
        {
            Item item = new Item(name, minimunPrice, salesPrice);

            List<Item> items = new List<Item>();
            items.Add(item);
        }
    }
}
