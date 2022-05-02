using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Interactable
    {
        private Dictionary<string, Result[]> _actions = new Dictionary<string, Result[]>();
        public Dictionary<string, Result[]> actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        public Dictionary<string, Result[]> getActions()
        {
            return (actions);
        }
        public void setActions(Dictionary<string, Result[]> newActions)
        {
            _actions.Concat(newActions);
        }
        public void deleteAction(Dictionary<string, Result[]> toDelete)
        {
            foreach( KeyValuePair<string, Result[]> value in _actions)
            {
                if (toDelete.ContainsKey(value.Key))
                {
                    if(toDelete[value.Key] == value.Value)
                    {
                        _actions.Remove(value.Key);
                    }
                }
            }
        }
        private string Inspect()
        {
            return ("Default Inspect Parent");
        }
    }
}
