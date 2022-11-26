/*Задача 64: Задайте значение N. Напишите метод, который выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите начальное число n - ");
bool isParseN = int.TryParse(Console.ReadLine(), out int n);

if (!isParseN)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n==0)
    {
        return;
    }
    Console.Write($"{n} ");
    PrintNumbers(n-1);
}