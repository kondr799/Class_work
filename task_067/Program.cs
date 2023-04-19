// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

Console.Clear();

int SumDigital(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + SumDigital(number / 10);
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SumDigital(number));

//Рекурсия: 123 -> 12 -> 1 -> 0.