using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Menu
    {

        //Constructor
        public Menu()
        {
            items = new List<MenuItem>();
        }

        //Properties
        public string Name;
        public List<MenuItem> items;
    }
}
