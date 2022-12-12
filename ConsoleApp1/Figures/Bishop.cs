namespace ConsoleApp1.Figures
{
    internal class Bishop:Figure
    {
        public Bishop(int[] startPosition, int[] endPosition)
         : base(startPosition, endPosition)
        {
            typeOfFigure = "Bishop";
        }
        public override bool IsPossibleMove()
        {
            return IsPossibleDiagonalMove() && MoveMoreThanZero();
        }
    }
}
