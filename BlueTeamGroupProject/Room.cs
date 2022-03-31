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

        private Dictionary<Locations.Direction, Room> Exits = new Dictionary<Locations.Direction, Room>();

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
            foreach (object obj in items)
            {
                _itemlist.addStuff(obj);
            }
            
        }

        public void addExit(Locations.Direction direction, Room place)
        {
            Exits[direction] =  place;
        }
        public void removeExit(Locations.Direction Placement, Room room)
        {
            foreach (var value in Exits)
            {
                
                if (value.Key == Placement && value.Value == room)
                {
                    Exits[value.Key] = null;
                }
            }
        }
        public Room getExit(Locations.Direction direction)
        {
            Room returnRoom;
            try
            {
                returnRoom = Exits.Single(c => c.Key == direction).Value;
            }
            catch
            {
                returnRoom = this;
            }
            return returnRoom;
            
            
        }
    }
}
