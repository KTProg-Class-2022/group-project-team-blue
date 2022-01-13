using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamGroupProject
{
    class Room
    {
        public enum RoomType
        {
            Static,
            Travel,
            Dungeon,
            Combat
        }

        private List<Location> Exits;
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

        public void addExit(Location place)
        {
            Exits.Append(place);
        }
        public void removeExit(Location.Direction Placement, string Name)
        {
            foreach (Location Exit in Exits)
            {
                if (Exit.Dir == Placement && Exit.ID == Name)
                {
                    Exits.Remove(Exit);
                }
            }
        }
    }
}
