using Console_Checkers.Boards.Basic;

namespace Console_Checkers
{
    public static class Checkers
    {
        public static void Main()
        {
            CheckersBoard board = new();
            board.Draw();

            string? choice = Console.ReadLine();

            while(!CheckersBoardRules.CheckForWin(board))
            {

            }
        }
    }
}
