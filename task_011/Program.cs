// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
// [100, 999]
int n = new Random().Next(100, 1000);
int n1 = n / 100;
int n2 = n % 10;

Console.WriteLine($"random = {n}");

Console.WriteLine(n1 * 10 + n2);
