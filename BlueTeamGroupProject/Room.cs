using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Room : Interactable
    {
        public enum RoomType
        {
            Static,
            Travel,
            Dungeon,
            Combat
        }

        private List<Tuple<Location.Direction, Room>> Exits = new List<Tuple<Location.Direction, Room>>();
        private RoomType _category;
        public RoomType Category
        {
            get { return _category; }
        }
        private Item[] _itemlist;
        public Item[] ItemList
        {
            get { return _itemlist; }
            set { _itemlist = value; }
        }
        private string _desc;
        public string Desc
        {
            get { return _desc; }
        }
        Room(RoomType Type, Item[] items, string description)
        {
            _category = Type;
            _itemlist = items;
        }
        public void addExit(Location.Direction direction, Room place)
        {
            Exits.Append(new Tuple<Location.Direction, Room>(direction, place));
        }
        public void removeExit(Location.Direction Placement, Room room)
        {
            foreach (Tuple<Location.Direction, Room> Exit in Exits)
            {
                if (Exit.Item1 == Placement && Exit.Item2 == room)
                {
                    Exits.Remove(Exit);
                }
            }
        }
    }
}
