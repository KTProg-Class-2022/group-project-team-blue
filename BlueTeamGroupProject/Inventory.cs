using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Inventory
    {
        private string _name;
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
        public string getValues()
        {
            string returnString = "";
            foreach(object value in Content)
            {
                if(value is Weapon)
                {
                    Weapon valWep = value as Weapon;
                    returnString+= "WEAPON: "+ valWep.Name + "\n";
                }
                if (value is Item)
                {
                    Item valItem = value as Item;
                    returnString += "ITEM: " + valItem.Name + " (" + valItem.Desc + ")\n";
                }
                
            }
            return (returnString);
        }



    }
}
