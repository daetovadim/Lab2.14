using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._14
{
    public enum Categories
    {
        Food = 1,
        Electronics = 2
    }
    public class Product
    {
        private double price;

        public string ProductName { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0;
            }
        }
        public string Image { get; set; }
        public Categories Category { get; set; }
    }
}
