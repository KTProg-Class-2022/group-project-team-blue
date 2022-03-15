using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Locations
    {
        public enum Direction
        {
            North,
            East,
            South,
            West
        }
        private Direction _Dir;
        public Direction Dir
        {
            get { return _Dir; }
        }
        private string _desc;
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        Locations(string id, string info, Direction Placement)
        {
            _Dir = Placement;
            _desc = info;
            _id = id;
        }

        
    }
}
