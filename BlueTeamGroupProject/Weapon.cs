﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Weapon
    {
        public Dictionary<string, Func<System.Object>> actionList = new Dictionary<string, Func<System.Object>>();
        
        private int _attack;
        public int Attack
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
        public Weapon(string name, int attack)
        {
            _name = name;
            _attack = attack;
            actionList.Add("Test", test1);
        }

        private System.Object test1()
        {
            return (false);
        }
    }
}
