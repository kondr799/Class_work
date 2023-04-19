// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

string PutNumber(int Number1, int Number2)
{
    if (Number1 == Number2)//F(5)
    return Number1.ToString();
    string Empty = String.Empty;
    return Empty + PutNumber(Number1, Number2 - 1) + ", " + Number2.ToString();
    // Рекурсия вниз, вычисление по методу:
    // F(5)=" + F(4),_ "5 '= '1,_2,_3,_4,_5 '
    // F(4)=" + F(3),_ "4 '= '1,_2,_3,_4 '
    // F(3)=" + F(2),_ "3 '= '1,_2,_3 '
    // F(2)=" + F(1),_ "2 '= ' 1,_2'
    // F(1) = 1; возврат вверх + конкатенация.
}

Console.Write("Введите 2 числа: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(PutNumber(numbers[0], numbers[1]));
