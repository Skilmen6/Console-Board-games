using Console_Checkers.Teams;
using Console_Checkers.Teams.Checkers;

namespace Console_Checkers.Boards.Basic
{
    public class CheckersBoard : IBoard
    {
        public CheckersBoard()
        {
            Reset();
        }

        public string[][] board = [[]];

        CheckersBlack bTeam = new();
        CheckersWhite wTeam = new();

        public string Empty => "e";
        public string EmptyDraw => " .";

        public void Reset()
        {
            board = [
                [Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece],
                [bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty],
                [Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece],
                [bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty, bTeam.piece, Empty],
                [Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty],
                [Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty, Empty],
                [Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece],
                [wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty],
                [Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece],
                [wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty, wTeam.piece, Empty],
            ];

            bTeam.Pieces = 20;
            wTeam.Pieces = 20;
        }

        public void Draw()
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            string output = "";
            for (int i = 0; i < board.Length; i++)
            {
                output += i;
                for (int ii = 0; ii < board[i].Length; ii++)
                {
                    if (board[i][ii] == wTeam.piece)
                    {
                        output += wTeam.pieceDraw;
                    }
                    else if (board[i][ii] == bTeam.piece)
                    {
                        output += bTeam.pieceDraw;
                    }
                    else if (board[i][ii] == Empty)
                    {
                        output += EmptyDraw;
                    }
                    else
                    {
                        output += " " + board[i][ii];
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

        public void CaptureChecks(ITeam currentTeam)
        {

        }
    }
}