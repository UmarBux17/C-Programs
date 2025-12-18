namespace Hanoi
{
    internal class Program
    {
        private const int DISC_COUNT = 5;
        private const int DELAYS_MS = 250;
        private static int _columnSize = 30;

        static void Main(string[] args)
        {
            _columnSize = Math.Max(6, GetDiscWidth(DISC_COUNT) + 2);
            HanoiTower algorithm = new HanoiTower(DISC_COUNT);
            algorithm.MoveCompleted += Algorithm_Visualize;
            Algorithm_Visualize(algorithm, EventArgs.Empty);
            algorithm.Start();
            Console.ReadLine();

        }//main ends
        private static void Algorithm_Visualize(object sender, EventArgs e)
        {
            Console.Clear();

            HanoiTower algorithm = (HanoiTower)sender;
            if (algorithm.DiscsCount <= 0) { return; }

            char[][] visualization = InitializeVisualization(algorithm);
            PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
            PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
            PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxilary);

            Console.WriteLine(Center("From") + Center("To") + Center("Auxilary"));
            DrawVisualization(visualization);
            Console.WriteLine();
            Console.WriteLine($"Number of moves: {algorithm.MovesCount}");
            Console.WriteLine($"Number of discs: {algorithm.DiscsCount}");
            
            Thread.Sleep(DELAYS_MS);
        }//method ends

        private static char[][] InitializeVisualization (HanoiTower algorithmn)
        {
            char[][] visualization = new char[algorithmn.DiscsCount][];
            for (int y = 0; y < visualization.Length; y++)
            {
                visualization[y] = new char[_columnSize * 3];
                for (int x = 0; x < _columnSize* 3; x++)
                {
                    visualization[y][x] = ' ';
                }//inner for loop
            }//other for loop

            return visualization;

        }//method ends

        private static void PrepareColumn(char[][] visualization, int column, int discsCount, Stack<int> stack) 
        {
            int margin = _columnSize * (column - 1);

            for (int y = 0; y < stack.Count; y++)
            {
                int size = stack.ElementAt(y);
                int row = discsCount - (stack.Count - y);
                int columnStart = margin + discsCount - size;
                int columnEnd = columnStart + GetDiscWidth(size);

                for (int x = columnStart; x <= columnEnd ; x++)
                {
                    visualization[row][x] = '=';
                }

            }//outer for loop
        }//method ends

        private static void DrawVisualization(char[][] visualization)
        {
            for (int y = 0; y < visualization.Length; y++)
            {
                Console.WriteLine(visualization[y]);
            }//for loop ends
        }//method ends

        private static string Center(string text)
        {
            int margin = (_columnSize - text.Length) / 2;
            return text.PadLeft(margin + text.Length).PadRight(_columnSize);
        }// string ends

        private static int GetDiscWidth(int size)
        {
            return 2 * size - 1;
        }


    }//class ends
}

