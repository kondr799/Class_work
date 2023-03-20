// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.Clear();
Console.Write("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 * n1 == n2 || n2 * n2 == n1)
{
    Console.WriteLine($"Да");
}
else
    Console.WriteLine($"Нет");