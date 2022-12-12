namespace ConsoleApp1.Figures
{
    internal class King:Figure
    {
        public King(int[] startPosition, int[] endPosition)
           : base(startPosition, endPosition)
        {
            typeOfFigure = "King";
        }
        public override bool IsPossibleMove()
        {
            return (path[0] < 2 && path[1] < 2) && MoveMoreThanZero();
        }
    }
}
