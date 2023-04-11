// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

int[] SingleLineInput(int reqSizeArray)
{
    int[] array;
    Console.WriteLine("Введите массив через пробел");
    do
    {
        array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        if (array.Length != reqSizeArray)
        {
            Console.WriteLine("Неверно ввели, попробуйте ещё раз");
        }
    } while (array.Length != reqSizeArray);
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows, cols]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillMatrix(int[,] matrix, int min, int max)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            matrix[rows, cols] = new Random().Next(min, max + 1);
        }
    }
}

int[,] CreateUserMatrix();
{
    Console.WriteLine("Введите размерность матрицы");
    int[] size = SingleLineInput(2);
    return new int[size[0], size[1]];
}

bool CheckSizeMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] ReleasMatrix(int[,] matrix)
{
    int[,] transpMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            transpMatrix[cols, rows] = matrix[rows, cols];
        }
    }
    return transpMatrix;
}

Console.Clear();
int[,] matrix = CreateUserMatrix();
FillMatrix(matrix, 1, 10);
PintMatrix(matrix);
if (CheckSizeMatrix(matrix))
{
    PrintMatrix(ReleaseMatrix(matrix));
}
else
{
    Console.WriteLine("Кол-во строк и кол-во столбцов не совпадает");
}