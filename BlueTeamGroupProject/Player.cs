using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Player
    {
        Inventory player = new Inventory("player");
        Weapon equip = null;
        Item items = null;



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
        public Player(string name)
        {
            this._name = name;
        }
        public enum Stats
        {
            HP,
            DMG,
            ARMOR,
            SANITY
        }

        private Weapon Equipted()
        {
            return null;
        }
        public void playerAdd(object item)
        {
            player.addStuff(item);
        }
        public string playerValue()
        {
            return player.getValues();
        }




    }
}
