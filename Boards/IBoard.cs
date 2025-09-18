namespace Console_Checkers.Boards
{
    public interface IBoard
    {
        public void Draw();
        public void Reset();
        public bool CheckForWin();

        string Empty { get; }
        string EmptyDraw { get; }
    }
}
