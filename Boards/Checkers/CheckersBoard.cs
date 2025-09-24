using Console_Checkers.HelperClasses;
using Console_Checkers.Teams.Checkers;

namespace Console_Checkers.Boards.Basic
{
    public class CheckersBoard : IBoard
    {
        public CheckersBoard()
        {
            bTeam = new CheckersTeam
            {
                Name = "Black",
                Piece = "b",
                PieceDraw = "b",
                King = "B",
                KingDraw = "B"
            };
            wTeam = new CheckersTeam
            {
                Name = "White",
                Piece = "w",
                PieceDraw = "w",
                King = "W",
                KingDraw = "W"
            };

            bTeam.Enemies = [
                wTeam.Piece,
                wTeam.King
            ];
            wTeam.Enemies = [
                bTeam.Piece,
                bTeam.King
            ];
            currentTurn = wTeam;
            Reset();
        }

        public string[][] board = [[]];

        CheckersTeam bTeam;
        CheckersTeam wTeam;
        public CheckersTeam currentTurn;

        public string Empty => "e";
        public string EmptyDraw => ".";

        public void Reset()
        {
            board = [
                [Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece],
                [bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty],
                [Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece],
                [bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty, bTeam.Piece, Empty],
                [Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty],
                [Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty],
                [Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece],
                [wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty],
                [Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece],
                [wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty, wTeam.Piece, Empty],
            ];

            bTeam.Pieces = 20;
            wTeam.Pieces = 20;
        }

        public void Draw(Position? selectedPosition = null)
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            string output = "";
            for (int i = 0; i < board.Length; i++)
            {
                output += i;
                for (int ii = 0; ii < board[i].Length; ii++)
                {
                    string trailingSpace = " ";
                    if (
                        selectedPosition != null
                        && i == selectedPosition.row
                        && ii == selectedPosition.column
                    )
                    {
                        output += ">";
                        trailingSpace = "";
                    }

                    if (board[i][ii] == wTeam.Piece)
                    {
                        output += trailingSpace + wTeam.PieceDraw;
                    }
                    else if (board[i][ii] == bTeam.Piece)
                    {
                        output += trailingSpace + bTeam.PieceDraw;
                    }
                    else if (board[i][ii] == Empty)
                    {
                        output += trailingSpace + EmptyDraw;
                    }
                    else
                    {
                        output += board[i][ii];
                    }
                }
                output += "\n";
            }
            Console.WriteLine(output);
        }

        public bool CheckForWin()
        {
            if (bTeam.Pieces <= 0)
            {
                Console.WriteLine("White has won");
                return true;
            }
            if (wTeam.Pieces <= 0)
            {
                Console.WriteLine("Black has won");
                return true;
            }
            return false;
        }

        public void CaptureChecks(CheckersTeam currentTeam)
        {

        }
    }
}