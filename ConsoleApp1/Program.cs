using ConsoleApp1.Figures;

class TestClass 
{    
    static void Main()
    {
        int[] startPosition = new int[2];
        int[] endPosition = new int[2];        
        var rnd = new Random();

        while (true)
        {
            startPosition[0] = rnd.Next(7);
            startPosition[1] = rnd.Next(7);
            endPosition[0] = rnd.Next(7);
            endPosition[1] = rnd.Next(7);
            List<Figure> figures= new List<Figure>();
            figures.Add(new Bishop(startPosition,endPosition));
            figures.Add(new Knight(startPosition, endPosition));
            figures.Add(new King(startPosition, endPosition));
            figures.Add(new Queen(startPosition, endPosition));
            figures.Add(new Rock(startPosition, endPosition));

            PrintChessBoard(startPosition, endPosition);
            Console.WriteLine();            

            Console.WriteLine("Start position is [{0},{1}] \nEnd position is [{2},{3}]",
                startPosition[0], startPosition[1], endPosition[0], endPosition[1]);
            Console.WriteLine();

            foreach(Figure f in figures)
            {
                Console.WriteLine("Move for {0} is {1}",f.TypeOfFigure(),f.IsPossibleMove());
            }

            
            Console.WriteLine("Press any key to continue");            
            Console.WriteLine("You pressed {0}",Console.ReadKey());
            Console.Clear();
        }
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
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.Write("* ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(i == endPosition[1] && j == endPosition[0])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("* ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.Write("0 ");
            }
            Console.WriteLine("");
        }
    }
    
}