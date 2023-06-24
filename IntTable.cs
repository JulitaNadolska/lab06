class Program
{
    static void Main()
    {
        int[,] intTable = new int[10, 10];
        int number = 1;
        int row = 0;
        int column = 0;
        int direction = 1;

        while (number <= 100)
        {
            intTable[row, column] = number++;

            if (direction == 1 && (column == 9 || intTable[row, column + 1] != 0))
            {
                direction = 2;
                row++;
            }
            else if (direction == 2 && (row == 9 || intTable[row + 1, column] != 0))
            {
                direction = 3;
                column--;
            }
            else if (direction == 3 && (column == 0 || intTable[row, column - 1] != 0))
            {
                direction = 4;
                row--;
            }
            else if (direction == 4 && (row == 0 || intTable[row - 1, column] != 0))
            {
                direction = 1;
                column++;
            }

            if (direction == 1)
                column++;
            else if (direction == 2)
                row++;
            else if (direction == 3)
                column--;
            else if (direction == 4)
                row--;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(intTable[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}