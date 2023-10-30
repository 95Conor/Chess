using Core.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class PlaceOutOfBoundsException : Exception
    {
        public PlaceOutOfBoundsException() : base("Attempted to generate a place which is out of bounds of the chess board.")
        {
        }

        public PlaceOutOfBoundsException(Place place) : base($"Attempted to generate a place which is out of bounds of the chess board: {place.X.ToString()}, {place.Y.ToString()}")
        {
        }
    }
}