// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Одномерная матрица: { 1, 9, 9, 0, 2, 8, 0, 9 }

// Двумерная  матрица: 1, 2, 3
//                     4, 6, 1
//                     2, 1, 6

int[,] IputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 50);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

int[] Convert2dTo1d(int[,] matrix)
{
    int k = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k++] = matrix[i, j];
        }
    }
    return array;
}

void PrintFr(int[] array)
{
    int count = 1;
    int oldValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == oldValue)
        count++;
        else
        {
            Console.WriteLine($"{oldValue} Встречается в массиве: {count} раз");
            count = 1;
            oldValue = array[i];
        }
    }
    Console.WriteLine($"{oldValue} Встречается в массиве: {count} раз");
}

Console.Clear();
int [,] matrix = IputMatrix();
int[] array = Convert2dTo1d(matrix);
Array.Sort(array);
PrintFr(array);