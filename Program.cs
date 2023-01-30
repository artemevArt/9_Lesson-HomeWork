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

int SumFromMtoN(int m, int n)
{
    if (m > n)
        return 0;
    return m + SumFromMtoN(m + 1, n);
}
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int sum = SumFromMtoN(m, n);
Console.WriteLine("Сумма чисел между М и N = " + sum);