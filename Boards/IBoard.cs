using Console_Checkers.HelperClasses;

namespace Console_Checkers.Boards
{
    public interface IBoard
    {
        public void Draw(Position? selectedPosition = null);
        public void Reset();
        public bool CheckForWin();

        string Empty { get; }
        string EmptyDraw { get; }
    }
}
