﻿using Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Game.Pieces
{
    public abstract class Piece
    {
        public Piece(PieceColour pieceColour, Place place)
        {
            Colour = pieceColour;
            CurrentPlace = place;
        }

        public readonly PieceColour Colour;

        public Place CurrentPlace { get; set; }

        // Inactive pieces have been captured and are off the board.
        public bool Active { get; set; }

        // Possible moves the piece can be moved to within one turn.
        // Does not account for other pieces on the board. This will be separate logic.
        // Each piece will implement differently based on their unique move type.
        // This will be based on their CurrentPlace.
        public abstract List<Place> PossibleMoves();
    }
}