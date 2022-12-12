namespace ConsoleApp1.Figures
{
    abstract class Figure
    {
        protected string typeOfFigure;
        int[] startPosition;
        int[] endPosition;
        protected int[] path;

        public string TypeOfFigure() 
        { return typeOfFigure;}
        protected Figure(int[] startPosition, int[] endPosition)
        {
            this.startPosition = startPosition;
            this.endPosition = endPosition;
            path = GetPath(startPosition,endPosition);
        }

        private int[] GetPath(int[] startPosition, int[] endPosition)
        {
            var moveX = Math.Abs(endPosition[0] - startPosition[0]);
            var moveY = Math.Abs(endPosition[1] - startPosition[1]);
            return new int[] { moveX, moveY };
        }
        public abstract bool IsPossibleMove();
        protected private bool IsPossibleDiagonalMove()
        {
            return MoveMoreThanZero() && path[0] == path[1];

        }
        protected private bool IsPossibleStraightMovie()
        {
            return (path[0] == 0 || path[1] == 0) && MoveMoreThanZero();
        }
        protected private bool MoveMoreThanZero()
        {
            return path[0] + path[1] > 0;
        }

    }
}
