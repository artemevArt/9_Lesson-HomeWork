//Task1

// void printNumbers(int n)
// {
//     if (n == 0)
//         return;
//     Console.Write(n + " ");
//     printNumbers(n - 1);
// }

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// printNumbers(n);

//Task2

// int SumFromMtoN(int m, int n)
// {
//     if (m > n)
//         return 0;
//     return m + SumFromMtoN(m + 1, n);
// }
// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// int sum = SumFromMtoN(m, n);
// Console.WriteLine("Сумма чисел между М и N = " + sum);

//Task3

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (m > 0 && n == 0)
//         return Ackermann(m - 1, 1);
//     else if (m > 0 && n > 0)
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     else
//         return -1;
// }
// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// int result = Ackermann(m, n);
// Console.WriteLine("Функция Аккермана = " + result);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Сколько цифр вы хотите поместить в квадратный двумерный массив?: ");
int n = int.Parse(Console.ReadLine());
int[,] spiralArray = new int[n, n];

int value = 1;
int minRow = 0;
int maxRow = n - 1;
int minCol = 0;
int maxCol = n - 1;

while (value <= n * n)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        spiralArray[minRow, i] = value;
        value++;
    }

    for (int i = minRow + 1; i <= maxRow; i++)
    {
        spiralArray[i, maxCol] = value;
        value++;
    }

    for (int i = maxCol - 1; i >= minCol; i--)
    {
        spiralArray[maxRow, i] = value;
        value++;
    }

    for (int i = maxRow - 1; i > minRow; i--)
    {
        spiralArray[i, minCol] = value;
        value++;
    }

    minRow++;
    minCol++;
    maxRow--;
    maxCol--;
}
PrintArray(spiralArray);