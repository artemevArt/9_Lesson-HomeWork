//Task1
void printNumbers(int n)
{
    if (n == 0)
        return;
    Console.Write(n + " ");
    printNumbers(n - 1);
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
printNumbers(n);
Console.ReadKey();