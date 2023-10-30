using Core.Game.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Game
{
    public class Board
    {
        public Board()
        {
            InitialisePlaces();
            InitialisePieces();
        }

        // Could be used in future to 'resume' a game which doesn't need instantiating
        public Board(List<Place> places, List<Piece> pieces)
        {
            Places = places;
            Pieces = pieces;
        }

        // Might eventually wrap this a level higher in a BoardPlace class, it'd have a place and some other stuff like 'bool occupied = true/false'.
        // Otherwise we don't really need it as all the pieces know their own places. But it may come in handy later, we'll see.
        public List<Place> Places { get; set; } = new List<Place>();

        public List<Piece> Pieces { get; set; } = new List<Piece>();

        // Initialise all possible places on the chessboard
        private void InitialisePlaces()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int ii = 1; ii <= 8; i++)
                {
                    Places.Add(new Place(i, ii));
                }
            }
        }

        // Draw all chess pieces in their respective start positions for both white and black sides
        private void InitialisePieces()
        {
            // Pawns
            for (int i = 1; i <= 8; i++)
            {
                Pieces.Add(new Pawn(Enums.PieceColour.White, new Place(i, 2)));
                Pieces.Add(new Pawn(Enums.PieceColour.Black, new Place(i, 7)));
            }

            // White
            Pieces.Add(new Rook(Enums.PieceColour.White, new Place(1, 1)));
            Pieces.Add(new Pawn(Enums.PieceColour.White, new Place(2, 1)));
            Pieces.Add(new Bishop(Enums.PieceColour.White, new Place(3, 1)));
            Pieces.Add(new Queen(Enums.PieceColour.White, new Place(4, 1)));
            Pieces.Add(new King(Enums.PieceColour.White, new Place(5, 1)));
            Pieces.Add(new Bishop(Enums.PieceColour.White, new Place(6, 1)));
            Pieces.Add(new Pawn(Enums.PieceColour.White, new Place(7, 1)));
            Pieces.Add(new Rook(Enums.PieceColour.White, new Place(8, 1)));

            // Black
            Pieces.Add(new Rook(Enums.PieceColour.Black, new Place(1, 8)));
            Pieces.Add(new Pawn(Enums.PieceColour.Black, new Place(2, 8)));
            Pieces.Add(new Bishop(Enums.PieceColour.Black, new Place(3, 8)));
            Pieces.Add(new Queen(Enums.PieceColour.Black, new Place(4, 8)));
            Pieces.Add(new King(Enums.PieceColour.Black, new Place(5, 8)));
            Pieces.Add(new Bishop(Enums.PieceColour.Black, new Place(6, 8)));
            Pieces.Add(new Pawn(Enums.PieceColour.Black, new Place(7, 8)));
            Pieces.Add(new Rook(Enums.PieceColour.Black, new Place(8, 8)));
        }
    }
}