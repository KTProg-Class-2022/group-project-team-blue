using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Room : Interactable
    {
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
        public enum RoomType
        {
            Static,
            Travel,
            Dungeon,
            Combat
        }

        private List<(Location.Direction, Room)> Exits = new List<(Location.Direction, Room)>();
        private RoomType _category;
        public RoomType Category
        {
            get { return _category; }
        }
        private Inventory _itemlist;
        public Inventory ItemList
        {
            get { return _itemlist; }
            set { _itemlist = value; }
        }
        private string _desc;
        public string Desc
        {
            get { return _desc; }
        }
        Room(RoomType Type, String name, List<object> objects, string description)
        {
            _name = name;
            _itemlist = new Inventory(name + "_Room");
            _category = Type;
            foreach (object obj in objects)
            {
                if (obj is Item)
                {
                    _itemlist.addStuff(obj as Item);
                }
                else if(obj is Weapon)
                {
                    _itemlist.addStuff(obj as Weapon);
                }
            }
            
        }

        public void addExit(Location.Direction direction, Room place)
        {
            Exits.Append((direction, place));
        }
        public void removeExit(Location.Direction Placement, Room room)
        {
            foreach ((Location.Direction a, Room b) in Exits)
            {
                
                if (a == Placement && b == room)
                {
                    Exits.Remove((a,b));
                }
            }
        }
    }
}
