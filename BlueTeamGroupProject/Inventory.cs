using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Inventory
    {
        private string _name = "Undefined";
        private List<int> IDs;
        private List<object> Items = new List<object>();
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Array[] itemProperties = { };
        public Item[] itmeList = { };

        public Inventory(string name)
        {
            this._name = name;
        }
        public void addItem(object item)
        {
            Items.Add(item);
        }
        public List<object> getItems()
        {
            return (Items);
        }
        public string getValues()
        {
            string returnString = "";
            foreach(object value in Items)
            {
                if(value is Weapon)
                {
                    Weapon valWep = value as Weapon;
                    returnString+= valWep.Name;
                }
                
            }
            return (returnString);
        }



    }
}
