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
        public bool[] Utilize()
        {
            bool[] Succeed = { };
            foreach(Result result in Attack)
            {

            }
            return (Succeed);
        }
        public override string ToString()
        {
            return Inspect();
        }
        private string Inspect()
        {
            string returnStr = _name + "\n";
            foreach (KeyValuePair<string, Result[]> action in actions)
            {
                returnStr += "\t" + action.Key + "\n";
                Result[] resultGroup = action.Value;
                foreach (Result res in resultGroup)
                {
                    returnStr += "\t\t" + res.ToString() + "\n";
                }
            }
            return returnStr;
        }


    }
}
