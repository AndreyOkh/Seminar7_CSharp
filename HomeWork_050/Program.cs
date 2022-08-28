// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int rowsLength = 3;
int columnsLength = 4;
double[,] matrix = FillMatrix(rowsLength, columnsLength);
PrintMatrix(matrix);

int findRow = ReadInt("Введите номер строки: ");
int findColumn = ReadInt("Введите номер столбца: ");

if (findRow < matrix.GetLength(0) && findColumn < matrix.GetLength(1)) Console.WriteLine(matrix[findRow, findColumn]);
else Console.WriteLine("Такого числа в массиве нет!");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

double[,] FillMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * 10, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}