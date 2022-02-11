using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Inventory : Interactable
    {
        private string _name = "Undefined";
        private List<int> IDs;
        private List<object> Content = new List<object>();
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

        public Inventory(string name)
        {
            this._name = name;
        }
        public void addStuff(object item)
        {
            Content.Add(item);
        }
        public List<object> getStuff()
        {
            return (Content);
            
        }
        
        public (List<Weapon>, List<Item>) getValues()
        {
            List<Weapon> weapons = new List<Weapon>();
            List<Item> items = new List<Item>();
            foreach (object value in Content)
            {
                if(value is Weapon)
                {
                    Weapon valWep = value as Weapon;
                    weapons.Append(valWep);
                }
                if (value is Item)
                {
                    Item valItem = value as Item;
                    items.Append(valItem);
                }
                
            }
            return (weapons, items);
        }

    }
}
