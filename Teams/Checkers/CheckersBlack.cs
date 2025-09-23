namespace Console_Checkers.Teams.Checkers
{
    public class CheckersBlack : ITeam
    {
        public string Name => "Black";
        public int Pieces { get; set; }

        public string piece = "b";
        public string pieceDraw = "b";
        public string king = "B";
        public string kingDraw = "B";
    }
}
