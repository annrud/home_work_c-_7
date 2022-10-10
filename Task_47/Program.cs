Console.Clear();
Console.WriteLine("Программа принимает на вход размеры " +
                  "массива m x n и выдаёт двумерный массив, " +
                  "заполненный случайными вещественными числами.");
Console.Write("Введите размер m: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер n: ");
int column = int.Parse(Console.ReadLine()!);

double[,] array = new double[row, column];
FillArray(array);
PrintArray(array);


void PrintArray(double[,] matr)
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


void FillArray(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(rand.Next(-10, 11) + 
                                    rand.NextDouble(),1);
        }
    }
}
