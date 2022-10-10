Console.Clear();
Console.WriteLine("Программа принимает на вход размеры " +
                  "массива m x n и выдаёт двумерный массив, " +
                  "заполненный случайными натуральными числами и находит " +
				  "среднее арифметическое элементов в каждом столбце.");

Console.Write("Введите размер m: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер n: ");
int column = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, column];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
double[] result = AverageSumColumn(array);
PrintArray(result);

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}


void FillMatrix(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

double[] AverageSumColumn(int[,] matr)
{
    double[] sum = new double[matr.GetLength(1)];
    for (int i = 0; i < sum.Length; i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum[i] += matr[j, i];
        }

        sum[i] = Math.Round(sum[i] / matr.GetLength(0), 1);
    }

    return sum;

}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length-1)
            Console.Write(", ");
    }

    Console.WriteLine();
}
