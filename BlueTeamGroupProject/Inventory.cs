using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Inventory
    {
        public int[] itemProperties = {1 };
        public Item[] itmeList = {new Item("fist") };
        
        public void inventory()
        {
           
        }
        public void add(string N, int I)
        {
            itmeList.Append(new Item(N));
            itemProperties.Append(I);
        }

        public void remove(string N, int I)
        {
            
        }
    }
}
