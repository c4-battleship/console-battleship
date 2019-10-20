using System;
using System.Collections.Generic;
using System.Text;

namespace battleship
{
    class Board
    {
        private static int BOARD_DIMENSION = 10;
        private int[,] PlayerOneGameBoard { get; set; }
        public Board()
        {
            PlayerOneGameBoard = new int[BOARD_DIMENSION, BOARD_DIMENSION];
        }

    }
}
