// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? string.Empty);

int[,] array1 = GetArray(row, columns, 0, 9);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(row, columns, 0, 9);
PrintArray(array2);

Console.WriteLine();

int[,] newArray = Composition(array1, array2);
PrintArray(newArray);

int[,] GetArray(int m, int n, int minVaiue, int maxVaiue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minVaiue, maxVaiue +1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Composition(int[,] arr1, int[,] arr2)
{
    int r = arr1.GetLength(0);
    int c = arr1.GetLength(1);
    int[,] arrNew = new int[r,c];
    for(int i = 0; i<arrNew.GetLength(0); i++)
    {
        for(int j = 0; j<arrNew.GetLength(1); j++)
        {
            arrNew[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
    return arrNew;
}