Console.Clear();
Console.WriteLine("Программа принимает число N - " +
                  "количество чисел последовательности Фиббоначи, " +
				  "которые нужно вывести.");
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
PrintFibonacci(number);

double Fibonacci(int numb, int sum = 1, int previousSum = 0)
{
    int sumCurrent = previousSum;
	if (numb == 1)
		sumCurrent = 1;
    for (int i = 2; i <= numb; i++)
    {
        sumCurrent = sum + previousSum;
        previousSum = sum;
        sum = sumCurrent;
        
    }

    return sumCurrent;
}

void PrintFibonacci(int numb)
{
    for (int i = 0; i < numb; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    }
}
