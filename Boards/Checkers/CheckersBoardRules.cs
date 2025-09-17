namespace Console_Checkers.Boards.Basic
{
    public static class CheckersBoardRules
    {
        public static bool CheckForWin(CheckersBoard board)
        {
            if (board.blackPieces <= 0)
            {
                Console.WriteLine("White has won");
                return true;
            }
            if (board.whitePieces <= 0)
            {
                Console.WriteLine("Black has won");
                return true;
            }
            return false;
        }
    }
}
