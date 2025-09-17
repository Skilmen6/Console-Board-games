namespace Console_Checkers.Boards.Basic
{
    public class CheckersBoard
    {
        public CheckersBoard()
        {
            Reset();
        }

        public string[][] board = [[]];
        public int whitePieces = 0;
        public int blackPieces = 0;

        public CheckersBoard Reset()
        {
            board = [
                ["e", "B", "e", "B", "e", "B", "e", "B", "e", "B"],
                ["B", "e", "B", "e", "B", "e", "B", "e", "B", "e"],
                ["e", "B", "e", "B", "e", "B", "e", "B", "e", "B"],
                ["B", "e", "B", "e", "B", "e", "B", "e", "B", "e"],
                ["e", "e", "e", "e", "e", "e", "e", "e", "e", "e"],
                ["e", "e", "e", "e", "e", "e", "e", "e", "e", "e"],
                ["e", "W", "e", "W", "e", "W", "e", "W", "e", "W"],
                ["W", "e", "W", "e", "W", "e", "W", "e", "W", "e"],
                ["e", "W", "e", "W", "e", "W", "e", "W", "e", "W"],
                ["W", "e", "W", "e", "W", "e", "W", "e", "W", "e"],
            ];

            whitePieces = 20;
            blackPieces = 20;
            return this;
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
                    switch (board[i][ii])
                    {
                        case "W":
                            output += " w";
                            break;
                        case "B":
                            output += " b";
                            break;
                        case "e":
                            output += " .";
                            break;
                        default:
                            output += " " + board[i][ii];
                            break;
                    }
                }
                output += "\n";
            }
            Console.WriteLine(output);
        }
    }
}