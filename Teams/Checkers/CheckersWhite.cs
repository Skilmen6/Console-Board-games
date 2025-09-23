namespace Console_Checkers.Teams.Checkers
{
    public class CheckersWhite : ITeam
    {
        public string Name => "White";
        public int Pieces { get; set; }

        public string piece = "w";
        public string pieceDraw = "w";
        public string king = "W";
        public string kingDraw = "W";
    }
}
