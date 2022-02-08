using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Character
    {
        public enum Stats
        {
            HP,
            DMG,
            AMR,
            SANITY,
            None
        }

        private Weapon equipped;
        public Weapon Equipped
        {
            get { return equipped; }
            set { equipped = value; }
        }
        private int Health;
        private int Damage;
        private int Armor;
        
        public int getHP()
        {
            return this.Health;
        }
    }
}
