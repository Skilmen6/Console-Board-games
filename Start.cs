using Console_Checkers.Boards.Basic;
using Console_Checkers.HelperClasses;
using Console_Checkers.Teams.Checkers;

namespace Console_Checkers
{
    public static class Start
    {
        public static void Main()
        {
            CheckersBoard board = new();

            board.Draw();

            string? choiceString = null;
            Position? selectedPosition = null;

            while(!board.CheckForWin())
            {
                choiceString = Console.ReadLine();

                if (choiceString == null)
                {
                    return;
                }

                string[] choiceParts = choiceString.Split(" ");

                if (choiceParts[0] == "select")
                {
                    selectedPosition = selectPosition(choiceParts);
                    Console.WriteLine($"Selected row: {selectedPosition.row}");
                    Console.WriteLine($"Selected column: {selectedPosition.column}");
                }

                board.Draw(selectedPosition);
            }
        }

        static private Position selectPosition(string[] choiceParts)
        {
            Position position = new();
            if (choiceParts.ElementAtOrDefault(1) == null)
            {
                Console.WriteLine("Select a row or position. Position can be selected as {row}.{column}");
                string? positionString = Console.ReadLine();

                if (positionString == null)
                {
                    return selectPosition(choiceParts);
                }

                string[] positionParts = positionString.Split(".");
                position = getPosition(positionParts);

            }
            else
            {
                string[] positionParts = choiceParts[1].Split(".");
                position = getPosition(positionParts);
            }
            return position;
        }

        static private Position getPosition(string[] positionParts)
        {
            Position position = new();
            if (positionParts.ElementAtOrDefault(1) == null)
            {
                // User input only row
                position.row = int.Parse(positionParts[0]);
                Console.WriteLine("Select a column.");
                position.column = getColumn();
            }
            else
            {
                // User input row and column
                position.row = int.Parse(positionParts[0]);
                position.column = int.Parse(positionParts[1]);
            }
            return position;
        }

        static private int getColumn()
        {
            string? columnString = Console.ReadLine();

            if (columnString == null)
            {
                return getColumn();
            }

            return int.Parse(columnString);
        }
    }
}
