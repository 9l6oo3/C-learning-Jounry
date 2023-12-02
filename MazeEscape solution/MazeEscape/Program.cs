namespace MazeEscape;
class Program
{
    static void Moving(ref int i, ref int j)
    {
        Console.WriteLine("Enter (U, L, R, D) ? ");
        string val = Console.ReadLine().ToUpper();

        if (val == "U" && i > 0)
        {
            i--;
        }
        else if (val == "D" && i < 4)
        {
            i++;
        }
        else if (val == "R" && j < 6)
        {
            j++;
        }
        else if (val == "L" && j > 0)
        {
            j--;
        }
        else
        {
            Console.WriteLine("Invalid Value!");
        }
    }

    static void DisplayMaze(int playerRow, int playerCol)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i == 0 || j == 0 || j == 6 || (i == 4 && j <= 4) || (i == 2 && j == 4) || (i == 3 && j == 4) || (i == 2 && j == 3) || (i == 2 && j == 2))
                {
                    Console.Write("#");
                }
                else if (i == 1 && j == 1 || i == playerRow && j == playerCol)
                {
                    Console.Write("S");
                }
                else if (i == 4 && j == 5)
                {
                    Console.Write("E");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int playerRow = 1, playerCol = 1;

        while (true)
        {
            DisplayMaze(playerRow, playerCol);
            Moving(ref playerRow, ref playerCol);

            if (playerRow == 4 && playerCol == 5)
            {
                Console.WriteLine("Congratulations! You reached the exit.");
                break; // Exit the game loop
            }
        }
    }
}

