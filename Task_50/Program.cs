Console.Clear();
Console.WriteLine("Программа принимает на вход позицию элемента -" + 
				  "номер строки и номер столбца и выдаёт значение " +
                  "элемента двумерного массива, если элемент " +
                  "присутствует в этом массиве.");


Console.WriteLine("Дан массив: ");
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Console.Write("Введите номер строки (нумерация с 0): ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца (нумерация с 0): ");
int column = int.Parse(Console.ReadLine()!);
int value = FindElement(array, row, column);
PrintResult(value);



void PrintArray(int[,] matr)
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


void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(10);
        }
    }
}

int FindElement(int[,] matr, int i, int j)
{
    if (i < matr.GetLength(0) && j < matr.GetLength(1))
    {
        return matr[i, j];
    }

    return -1;

}

void PrintResult(int result)
{
    if (result != -1)
        Console.WriteLine($"Значение элемента: {result}");   
    else 
        Console.WriteLine("Такого элемента в массиве нет");   
}
