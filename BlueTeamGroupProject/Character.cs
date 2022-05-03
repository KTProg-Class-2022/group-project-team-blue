using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Character
    {
        
        Weapon equipped = null;
        Item items = null;
        public Inventory inv;

        private Character _foe;
        public Character Foe
        {
            get { return (_foe); }
            set { _foe = value; }
        }
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
        public void setDMG(int value)
        {
            this.Damage = value;
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
        public enum Stats
        {
            HP,
            DMG,
            ARMOR,
            SANITY,
            None
        }
        public Dictionary<Stats, int> StatsRef = new Dictionary<Stats, int>();
        public Character(string name)
        {
            this._name = name;
            this.inv = new Inventory(name + "_inv");
            this.StatsRef[Stats.HP] = this.getHP();
            this.StatsRef[Stats.DMG] = this.getDMG();
            this.StatsRef[Stats.ARMOR] = this.getARMOR();
            this.StatsRef[Stats.SANITY] = this.getSanity();
        }
        
        
        public void Equip(Weapon chosen)
        {
            this.equipped = chosen;
            
        }
        public Weapon Equipped
        {
            get { return (equipped); }
        }
        public bool Hit(int amount)
        {
            int hitAmount = (amount - Armor);
            if (hitAmount <= 0)
            {
                return (false);
            }
            else
            {
                Health -= hitAmount;
                return (true);
            }
        }
        Result[] currentAilments;
        public void Affliction(Result.Targets From, Result.Targets To, Result What)
        {
            if(To == Result.Targets.Self)
            {
                StatsRef[What.Affected] = StatsRef[What.Affected] - What.Level;
                currentAilments.Append(What);
            }
            else if(To == Result.Targets.Both)
            {
                
                Affliction(Result.Targets.Self, Result.Targets.Self, What);
                Foe.Affliction(Result.Targets.Enemy, Result.Targets.Self, What);
            }
            else if(To == Result.Targets.Enemy)
            {
                Foe.Affliction(Result.Targets.Enemy, Result.Targets.Self, What);
            }
            
            
        }
        public void nextTurn()
        {
            Result[] newAilments = new Result[10];
            currentAilments = currentAilments.Where(x => x.Duration > 0).ToArray();
            foreach(Result Ailment in currentAilments)
            {
                Result ail = Ailment.nextTurn();
                if (ail.Level != 0)
                {
                    newAilments.Append(ail);
                }
                
                
            }
            currentAilments = newAilments;
        }
        


    }
}
