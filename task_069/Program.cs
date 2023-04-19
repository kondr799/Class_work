// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

Console.Clear();

int Pow(int a, int b)
{
    if (b == 0) return 1;
    return a * Pow(a, b -1);
}

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(a, b));
// A^B = A * A^(B - 1)