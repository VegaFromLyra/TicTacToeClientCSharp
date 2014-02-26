using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeClientCSharp
{
    public enum Piece
    {
        Empty,
        O,
        X
    };

    class TicTacToe
    {

        private Piece[,] board;

        static private int N = 3;

        public void Init(Piece[,] board)
        {
            this.board = board;
        }

        public Piece hasWon()
        {
            // Check rows
            for (int i = 0; i < N; i++)
            {
                if (board[i, 0] != Piece.Empty &&
                    board[i, 0] == board[i, 1] &&
                    board[i, 1] == board[i, 2])
                {
                    return board[i, 0];
                }
            }

            // Check columns
            for (int i = 0; i < N; i++)
            {
                if (board[0, i] != Piece.Empty &&
                    board[0, i] == board[1, i] &&
                    board[1, i] == board[2, i])
                {
                    return board[0, i];
                }
            }

            // Check Diagonal 1
            if (board[0, 0] != Piece.Empty &&
                board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }

            // Check diagonal 2
            if (board[2, 0] != Piece.Empty &&
                board[2, 0] == board[1, 1] &&
                board[1, 1] == board[0, 2])
            {
                return board[2, 0];
            }

            return Piece.Empty;
        }
    }
}
