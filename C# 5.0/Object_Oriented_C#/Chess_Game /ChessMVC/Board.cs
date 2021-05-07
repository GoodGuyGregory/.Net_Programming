using System;

namespace ChessMVC
{
    public class Board
    {
        private ChessPiece[,] board = new ChessPiece[8, 8];
        public ChessPiece this[int col, int row]
        {
            get
            {
                return Board[col - 1, row - 1];
            }
            set
            {
                Board[col - 1, row - 1] = value;
            }
        }
    }
}