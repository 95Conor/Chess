using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Game
{
    public class Place
    {
        public Place(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Place()
        {
        }

        private int _x;

        public int X
        {
            get { return _x; }
            set
            {
                if (_x > 8)
                {
                    throw new PlaceOutOfBoundsException(this);
                }
                _x = value;
            }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set
            {
                if (_y > 8)
                {
                    throw new PlaceOutOfBoundsException(this);
                }
                _y = value;
            }
        }

        public bool IntersectsWith(Place p)
        {
            return this == p;
        }

        public static bool operator ==(Place p1, Place p2) => p1.X == p2.X && p1.Y == p2.Y;

        public static bool operator !=(Place p1, Place p2) => !(p1 == p2);
    }
}