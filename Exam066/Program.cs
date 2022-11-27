/*Задача 66: Задайте значения M и N. Напишите метод, который найдёт 
сумму натуральных элементов в промежутке от M до N. Через рекурсию!
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите начальное число n - ");
bool isParseN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите конечное число m - ");
bool isParseM = int.TryParse(Console.ReadLine(), out int m);

if (!isParseN || !isParseM)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

int sum=SumNumbers(n,m);
Console.WriteLine($"сумма={sum} ");

int SumNumbers(int n, int m)
{
    int sum=0;
    if (n <= m)
    {
        sum+=n;
        n++;
        sum+=SumNumbers(n, m);
    }
    return sum;
}
