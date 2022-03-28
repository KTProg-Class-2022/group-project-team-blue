using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Character
    {
        
        Weapon equip = null;
        Item items = null;
        public Inventory inv;


        private int Health;
        public int getHP()
        {
            return this.Health;
        }
        private int Damage;
        public int getDMG()
        {
            return this.Damage;
        }
        private int Armor;
        public int getARMOR()
        {
            return this.Armor;
        }
        private int Sanity;
        public int getSanity()
        {
            return this.Sanity;
        }

        private string _name;
        public Character(string name)
        {
            this._name = name;
            this.inv = new Inventory(name + "_inv");
        }
        public enum Stats
        {
            HP,
            DMG,
            ARMOR,
            SANITY,
            None
        }

        private Weapon Equipted()
        {
            return null;
        }
        public void playerAdd(object item)
        {
            this.inv.addStuff(item);
        }
        public (List<Weapon>, List<Item>) playerValue()
        {
            return this.inv.getValues();
        }




        public List<object> playerStuff()
        {
            return this.inv.getStuff();
        }
        


    }
}
