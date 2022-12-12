namespace ConsoleApp1.Figures
{
    internal class Queen:Figure
    {
        public Queen(int[] startPosition, int[] endPosition)
           : base(startPosition, endPosition)
        {
            typeOfFigure = "Queen";
        }
        public override bool IsPossibleMove()
        {            
            return IsPossibleStraightMovie() || IsPossibleDiagonalMove();            
        }

    }
}
