/*Задача 63-65: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от n до m.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

Console.WriteLine("Введите начальное число n - ");
bool isParseN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите конечное число m - ");
bool isParseM = int.TryParse(Console.ReadLine(), out int m);

if (!isParseN || !isParseM)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}
PrintNumbers(m,n);

void PrintNumbers(int n, int i = 1)
{
    if (i > n)
    {
        return;
    }
    Console.Write($"{i} ");
    PrintNumbers(n, i + 1);
}
