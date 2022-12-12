namespace ConsoleApp1.Figures
{
    internal class Rock:Figure
    {
        public Rock(int[] startPosition, int[] endPosition)
           : base(startPosition, endPosition)
        {
            typeOfFigure = "Rock";
        }
        public override bool IsPossibleMove()
        {
            return IsPossibleStraightMovie();
        }
    }
}
