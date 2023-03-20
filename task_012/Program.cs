// Group

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток (4)
// 16, 4 -> кратно

Console.Clear();
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 % n2 == 0)
{
    Console.WriteLine($"Да");
}
else
    Console.WriteLine($"Нет, остаток = {n1 % n2}");
