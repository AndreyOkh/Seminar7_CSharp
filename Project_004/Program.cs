// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");

int[,] matrix = FillMatrix(m, n, 1, 9);
PrintMatrix(matrix);
Console.WriteLine(SumDiagonal(matrix));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int SumDiagonal(int[,] matrix)
{
    int sum = 0;
    int matrixLength = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1)) {matrixLength = matrix.GetLength(1);}

    for (int i = 0; i < matrixLength; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}