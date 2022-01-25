using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class WeaponsList
    {
        private string _name;
        private int _damage;
        public Array _weapons;

        public WeaponsList(string s, int i) {
            _name = s;
            _damage = i;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


    }
}
