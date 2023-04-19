// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

string PutNumber(int Number)
{
    if (Number == 1)//F(5)
    return 1.ToString();
    string Empty = String.Empty;
    return Empty + PutNumber(Number - 1) + ", " + Number.ToString();
    // Рекурсия вниз, вычисление по методу:
    // F(5)=" + F(4),_ "5 '= '1,_2,_3,_4,_5 '
    // F(4)=" + F(3),_ "4 '= '1,_2,_3,_4 '
    // F(3)=" + F(2),_ "3 '= '1,_2,_3 '
    // F(2)=" + F(1),_ "2 '= ' 1,_2'
    // F(1) = 1; возврат вверх + конкатенация.
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(PutNumber(number));

