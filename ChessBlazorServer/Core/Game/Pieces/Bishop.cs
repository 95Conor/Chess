using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Game.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(PieceColour pieceColour, Place place) : base(pieceColour, place)
        {
        }

        public override List<Place> PossibleMoves()
        {
            throw new NotImplementedException();
        }
    }
}