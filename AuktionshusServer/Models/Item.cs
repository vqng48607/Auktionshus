using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuktionhusServer.Models
{
    public class Item
    {
        public string Name { get; set; }
        public decimal MinimunPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public DateTime AuktionTime { get; set; }


        public Item(string name, decimal minimunPrice, decimal salesPrice)
        {
            Name = name;
            MinimunPrice = minimunPrice;
            SalesPrice = salesPrice;
            
        }

    }


}


