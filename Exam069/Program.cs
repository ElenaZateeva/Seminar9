/*Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8*/

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int exp = Exponentiate(A, B);
Console.WriteLine(exp);

int Exponentiate(int A, int B)
{
    int exp = 1;
    if (B != 0)
    {
        exp *= A;
        B--;
        exp *= Exponentiate(A,B); 
    }
    return exp;
}

