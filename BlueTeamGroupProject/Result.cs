using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Result
    {
        private string _effect;
        public string Effect
        {
            get { return (_effect); }
            set { _effect = value; }
        }
        public enum Targets
        {
            Enemy,
            Self,
            Both,
            None
        }
        private Targets _target;
        public Targets Target
        {
            get { return _target; }
            set { _target = value; }
        }
        
        private Character.Stats _affected;
        public Character.Stats Affected
        {
            get { return _affected; }
            set { _affected = value; }
        }
        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private bool _isIncreasing = false;
        public bool Increasing
        {
            get { return _isIncreasing; }
            set { _isIncreasing = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Result(string Text = "inflicted",Targets target = Targets.None, Character.Stats stat = Character.Stats.None, int level = 1, int duration = 1, bool isIncreasing = false)
        {
            this.Effect = Text;
            this.Target = target;
            this.Affected = stat;
            this._level = level;
            this._duration = duration;
            this._isIncreasing = isIncreasing;

        }
        public Result nextTurn()
        {
            if (Increasing)
            {
                Level++;
            }
            return (this);
        }
        public int getDuration()
        {
            int returnVal;
            if (Increasing)
            {
                returnVal = -1;
            }
            else
            {
                returnVal = Duration;
            }
            return (returnVal);
        }
        public override string ToString()
        {
            return ("Hello");
        }



    }
}
