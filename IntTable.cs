class Program
{
    static void Main()
    {
        Console.Write("Enter size of the table: ");
        int tableSize = int.Parse(Console.ReadLine());

        int[,] newTable = new int[tableSize, tableSize];
        int number = 1;
        int row = 0;
        int column = 0;
        int direction = 1;

        while (number <= tableSize * tableSize)
        {
            newTable[row, column] = number++;

            if (direction == 1 && (column == tableSize - 1 || newTable[row, column + 1] != 0))
            {
                direction = 2;
                row++;
            }
            else if (direction == 2 && (row == tableSize - 1 || newTable[row + 1, column] != 0))
            {
                direction = 3;
                column--;
            }
            else if (direction == 3 && (column == 0 || newTable[row, column - 1] != 0))
            {
                direction = 4;
                row--;
            }
            else if (direction == 4 && (row == 0 || newTable[row - 1, column] != 0))
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

        for (int i = 0; i < tableSize; i++)
        {
            for (int j = 0; j < tableSize; j++)
            {
                Console.Write(newTable[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}