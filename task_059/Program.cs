﻿// Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент
// массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 12);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] GetMinIndex(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] result = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] DeleteElementPosition(int[,] matrix, int[] array)
{
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == array[0])
            continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == array[1])
                continue;
            resultMatrix[row, column] = matrix[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] SizeOfMatrix = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[SizeOfMatrix[0], SizeOfMatrix[1]];

InputMatrix(Matrix);
//PrintMatrix(Matrix);
int[] Index = GetMinIndex(Matrix);
//DeleteElementPosition(Matrix, Index);
int[,] NewMatrix = DeleteElementPosition(Matrix, Index);
Console.WriteLine();
PrintMatrix(NewMatrix);