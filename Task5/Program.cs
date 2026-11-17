using System;

class Program
{
    // Матрицаны экранға шығару методы
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Матрица:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }

            Console.WriteLine();
        }
    }

    // Ең үлкен қосындысы бар жолды табу методы
    static void FindMaxSumRow(int[,] matrix)
    {
        int maxSum = 0;
        int maxRow = 0;

        // Бірінші жолдың қосындысын бастапқы мән ретінде аламыз
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            maxSum += matrix[0, j];
        }

        // Қалған жолдардың қосындысын есептейміз
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int currentSum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentSum += matrix[i, j];
            }

            // Егер жаңа қосынды үлкен болса, жаңартамыз
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxRow = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ең үлкен қосындысы бар жол: " + (maxRow + 1));
        Console.WriteLine("Осы жолдың қосындысы: " + maxSum);
    }

    static void Main()
    {
        int nomer = 11;
        int n = 5;

        int[,] matrix = new int[n, n];

        Random rnd = new Random(nomer);

        // Матрицаны кездейсоқ сандармен толтыру
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }

        // Матрицаны шығару
        PrintMatrix(matrix);

        // Ең үлкен қосындысы бар жолды табу
        FindMaxSumRow(matrix);
    }
}
