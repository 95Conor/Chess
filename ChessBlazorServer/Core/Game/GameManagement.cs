using Core.Game.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Game
{
    public class GameManagement
    {
        public GameManagement()
        {
        }

        public Board GameBoard { get; set; }

        public void InitialiseGame()
        {
            GameBoard = new Board();
        }
    }
}