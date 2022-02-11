using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Weapon : Interactable
    {
        
        
        private Result[] _attack;
        public Result[] Attack
        {
            get
            {
                return _attack;
            }
            set
            {
                _attack = value;
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Weapon(string name, Result[] result)
        {
            _name = name;
            _attack = result;
            
        }

        
    }
}
