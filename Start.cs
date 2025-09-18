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

            string? consoleChoiceString = null;
            Position selectedPosition;

            while(!board.CheckForWin())
            {
                consoleChoiceString = Console.ReadLine();

                if (consoleChoiceString == null)
                {
                    return;
                }

                string[] consoleChoice = consoleChoiceString.Split(" ");

                foreach(string choice in consoleChoice)
                {
                    Console.WriteLine(choice);
                }

                //switch (choice)
                //{
                //    case "help":
                //        break;

                //    case "select":
                //        string test = choice.Substring(0, 4);
                //        Console.WriteLine(test);
                //        choice = null;
                //        break;
                //}
            }
        }
    }
}
