class Program
{
    static void Main()
    {
        Console.Write("Enter size of the table: ");
        int tableSize = int.Parse(Console.ReadLine());

        int[,] table = new int[tableSize, tableSize];
        int number = 1;

        for (int i = 0; i < tableSize; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < tableSize; j++)
                {
                    table[i, j] = number++;
                }
            }
            else
            {
                for (int j = tableSize - 1; j >= 0; j--)
                {
                    table[i, j] = number++;
                }
            }
        }

        for (int i = 0; i < tableSize; i++)
        {
            for (int j = 0; j < tableSize; j++)
            {
                Console.Write(table[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}