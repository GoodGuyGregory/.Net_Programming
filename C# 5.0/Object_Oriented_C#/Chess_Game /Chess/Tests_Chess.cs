using System.Collections.Generic;
using ChessMVC.Chess;

namespace Tests
{
    [TestClass]
    public class Test_Chess
    {
        [TestMethod]
        public void Test_001()
        {
            // Model
            // View 
            //  Controller

            // var moves = new List<string>();

            // var game = new Chess();
            // var board = new Board();
            // var printer = new BoardPrinter();

            // foreach (var move in moves)
            // {
            //     game.Apply(move, board);

            //     printer.Show(board);
            // }
        }

        [TestMethod]
        public void Test_002()
        {
            // Model
            // View 
            //  Controller

            var moves = new List<string>();

            var game = new Chess();
            var board = new Board();
            var printer = new BoardPrinter();

            board.Move += (move) => Debug.WriteLine("");


            game.Result += (result) => Debug.WriteLine("");
            game.Capture += (piece, position) => Debug.WriteLine("");

            foreach (var move in moves)
            {
                game.Apply(move, board);

                printer.Show(board);
            }
        }

        private class BoardPrinter
        {

        }
    }
}