using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeClientCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();

            Piece[,] input1 = new Piece[,] {
                                             {Piece.X, Piece.X, Piece.X},
                                             {Piece.O, Piece.X, Piece.O},
                                             {Piece.X, Piece.O, Piece.O}
                                          };
            game.Init(input1);
            Console.WriteLine("Test case 1: Winner is {0}", game.hasWon());


            Piece[,] input2 = new Piece[,] {
                                             {Piece.O, Piece.X, Piece.X},
                                             {Piece.O, Piece.X, Piece.O},
                                             {Piece.O, Piece.O, Piece.X}
                                          };
            game.Init(input2);
            Console.WriteLine("Test case 2: Winner is {0}", game.hasWon());


            Piece[,] input3 = new Piece[,] {
                                             {Piece.X, Piece.O, Piece.X},
                                             {Piece.O, Piece.X, Piece.O},
                                             {Piece.O, Piece.O, Piece.X}
                                          };
            game.Init(input3);
            Console.WriteLine("Test case 3: Winner is {0}", game.hasWon());

            Piece[,] input4 = new Piece[,] {
                                             {Piece.X, Piece.O, Piece.O},
                                             {Piece.X, Piece.O, Piece.O},
                                             {Piece.O, Piece.O, Piece.X}
                                          };
            game.Init(input4);
            Console.WriteLine("Test case 4: Winner is {0}", game.hasWon());
        }
    }
}
