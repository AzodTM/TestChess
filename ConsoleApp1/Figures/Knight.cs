namespace ConsoleApp1.Figures
{
    internal class Knight:Figure
    {
        public Knight(int[] startPosition, int[] endPosition)
           : base(startPosition, endPosition)
        {
            typeOfFigure = "Knight";
        }
        public override bool IsPossibleMove()
        {
            return MoveMoreThanZero() && path[0] != path[1] && (path[0] == 1 && path[1] == 2) || (path[0] == 2 && path[1] == 1);
        }
    }
}
