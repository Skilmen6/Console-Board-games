using Console_Checkers.HelperClasses;

namespace Console_Checkers.Pieces
{
    public interface IPiece
    {
        string BoardNotation { get; }
        string DrawNotation { get; }

        public bool Move(
            Position startPosition,
            Position newPosition
        );
    }
}
