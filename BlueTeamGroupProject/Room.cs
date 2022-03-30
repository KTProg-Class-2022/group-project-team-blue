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
            Combat,
            Normal
        }

        private List<(Locations.Direction, Room)> Exits = new List<(Locations.Direction, Room)>();

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
        public Room(RoomType Type, String name, List<object> items, string description)
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

        public void addExit(Locations.Direction direction, Room place)
        {
            Exits.Append((direction, place));
        }
        public void removeExit(Locations.Direction Placement, Room room)
        {
            foreach ((Locations.Direction a, Room b) in Exits)
            {
                
                if (a == Placement && b == room)
                {
                    Exits.Remove((a,b));
                }
            }
        }
        public Room getExit(Locations.Direction direction)
        {
            Room returnRoom;
            try
            {
                returnRoom = Exits.Single(c => c.Item1 == direction).Item2;
            }
            catch
            {
                returnRoom = this;
            }
            return returnRoom;
            
            
        }
    }
}
