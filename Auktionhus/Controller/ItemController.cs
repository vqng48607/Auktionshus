using Auktionhus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auktionhus.Controller
{
    internal class ItemController
    {
        public void Create(int id, decimal minimunPrice, decimal salesPrice, DateTime auktionTime)
        {
            Item item = new Item(id, minimunPrice, salesPrice, auktionTime);

            List<Item> items = new List<Item>();
            items.Add(item);
        }
    }
}
