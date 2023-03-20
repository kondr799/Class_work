// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:

// 78 -> 8
// 12 -> 2
// 85 -> 8

Console.Clear();
int n = new Random().Next(10, 99); // [10, 99]
int n1 = n / 10;
int n2 = n % 10;
Console.WriteLine($"random = {n}");

if (n1 > n2)
Console.WriteLine(n1);
else if (n1 < n2)
Console.WriteLine(n2);
else
Console.WriteLine("=");
