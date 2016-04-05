using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class MenuItem
    {
        public string ProductName;
        public string Description;
        public double price
        {
            get { return _price; }
            set { 
                if (value >0)
                {
                    _price = value;
                }
                else 
                {
                       
                }
                
                }

        }

        private double _price;
    }
}
