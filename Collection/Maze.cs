using System;

namespace Collection
{
    class Program
    {
        class CustomPoint
        {
            public int X { get; set; }
            public int Y { get; set; }

            public CustomPoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        static char[,] maze = new char[,]
        {
            {'1','E','1','1','1','1','1','1','1','1'},
            {'1','0','1','1','0','0','1','0','0','0'},
            {'1','0','0','0','0','0','1','0','1','0'},
            {'1','0','1','1','0','0','1','0','1','0'},
            {'1','1','1','1','0','0','1','0','1','0'},
            {'1','1','1','1','1','0','0','0','S','0'},
            {'1','1','1','1','1','1','1','1','1','1'},
        };

        static int startRow, startCol;
        static int endRow, endCol;
        static ArrayStack path = new ArrayStack(100); // Assuming initial capacity of 100
        static char[,] visited;
        static bool exitFound = false;

        static void Main(string[] args)
        {
            // Find the start and end positions
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (maze[row, col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    if (maze[row, col] == 'E')
                    {
                        endRow = row;
                        endCol = col;
                    }
                }
            }

            visited = new char[maze.GetLength(0), maze.GetLength(1)];
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    visited[row, col] = ' ';
                }
            }

            // Begin exploring the maze from the starting position
            ExploreMaze(startRow, startCol);

            if (!exitFound)
            {
                Console.WriteLine("No exit found!");
            }

            Console.ReadKey();
        }

        static void ExploreMaze(int currentRow, int currentCol)
        {
            ArrayStack stack = new ArrayStack(100); // Assuming initial capacity of 100

            stack.push(new CustomPoint(currentCol, currentRow));

            while (!stack.isEmpty())
            {
                CustomPoint currentPoint = (CustomPoint)stack.pop();
                currentRow = currentPoint.Y;
                currentCol = currentPoint.X;

                visited[currentRow, currentCol] = 'V';
                path.push(currentPoint);
                maze[currentRow, currentCol] = '.'; // Turn '0' into '.'

                int[] rowOffsets = { -1, 1, 0, 0 };
                int[] colOffsets = { 0, 0, -1, 1 };

                bool foundPath = false;

                for (int k = 0; k < 4; k++)
                {
                    int m = currentRow + rowOffsets[k];
                    int n = currentCol + colOffsets[k];

                    if (m >= 0 && m < maze.GetLength(0) && n >= 0 && n < maze.GetLength(1))
                    {
                        if (maze[m, n] == 'E')
                        {
                            Console.WriteLine("Exit found!");
                            exitFound = true;
                            return;
                        }
                        else if (maze[m, n] == '0' && visited[m, n] != 'V')
                        {
                            foundPath = true;
                            stack.push(new CustomPoint(n, m));
                        }
                    }
                }

                if (!foundPath)
                {
                    path.pop();
                    visited[currentRow, currentCol] = 'V';
                }
            }
        }
    }
}

