using Console_Checkers.Boards;
using Console_Checkers.HelperClasses;
using Console_Checkers.Teams;

namespace Console_Checkers.Pieces
{
    public interface IPiece
    {
        public bool Move(
            Position startPosition,
            Position endPosition,
            IBoard board
        );
    }
}
