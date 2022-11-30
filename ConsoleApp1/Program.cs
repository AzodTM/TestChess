class TestClass 
{    
    static void Main()
    {
        int[] startPosition = new int[2];
        int[] endPosition = new int[2];
        int[] path;
        var rnd = new Random();
        while (true)
        {
            startPosition[0] = rnd.Next(7);
            startPosition[1] = rnd.Next(7);
            endPosition[0] = rnd.Next(7);
            endPosition[1] = rnd.Next(7);

            PrintChessBoard(startPosition, endPosition);
            path = GetPath(startPosition, endPosition);

            Console.WriteLine("Start position is [{0},{1}] \nEnd position is [{2},{3}]",
                startPosition[0], startPosition[1], endPosition[0], endPosition[1]);
            
            Console.WriteLine("Step by Bishop is {0}", IsPossibleForBishopMove(path));
            Console.WriteLine("Step by Knight is {0}", IsPossibleForKnightMove(path));
            Console.WriteLine("Press any key to continue");            
            Console.WriteLine("You pressed {0}",Console.ReadKey());
            Console.Clear();
        }
    }
    static private bool IsPossibleForBishopMove(int[] path)
    {
        return IsPossibleDiagonalMove(path);
    }
    static private bool IsPossibleForKnightMove(int[] path)
    {        
        if (path[0] != path[1] && (path[0] == 1 && path[1] == 2) || (path[0] == 2 && path[1] == 1))
            return true;
        return false;
    }
    static private bool IsPossibleDiagonalMove(int[] path)
    {        
        if (path[0] != 0 && path[0] == path[1])
        {
            return true;
        }
        return false;
    }
    static private bool IsPossibleStraightMovie(int[] path)
    {
        return path[0] == path[1];
    }
    static private int[] GetPath(int[] startPosition, int[] endPosition)
    {
        var moveX = Math.Abs(endPosition[0] - startPosition[0]);
        var moveY = Math.Abs(endPosition[1] - startPosition[1]);
        return new int[] { moveX, moveY };
    }
    static private bool MoveMoreThanAero(int[] path)
    {
       return path[0] + path[1] > 0;
    }
    static private void PrintChessBoard(int[] startPosition, int[] endPosition)
    {
        var sizeOfChessBoard = 8;
        for (int i = 0; i < sizeOfChessBoard; i++)
        {
            for (int j= 0; j < sizeOfChessBoard; j++)
            {
                if (i == startPosition[1] && j == startPosition[0])
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.Write("* ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(i == endPosition[1] && j == endPosition[0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.Write("0 ");
            }
            Console.WriteLine("");
        }
    }
    
}