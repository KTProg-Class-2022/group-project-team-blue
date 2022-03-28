using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Item : Interactable
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _desc;
        public string Desc
        {
            get { return _desc; }
            set { _desc= value; }
        }
        //Dictionary<string, string> actions = new Dictionary<string, string>();


        public Item(string name, string Desc, string[] Commands, Result[][] Results)
        {
            _name = name;
            if (Commands.Length != Results.Length)
            {
                Console.WriteLine("The Results and Commands are unbalanced");
            }
            else
            {
                for(int i = 0; i < Commands.Length; i++)
                {
                    actions[Commands[i]] = Results[i];
                }
            }
        }
        public void addAction(string Command, Result[] Result)
        {
            actions[Command] = Result;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
