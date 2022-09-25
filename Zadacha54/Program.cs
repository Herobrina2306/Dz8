// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? string.Empty);

int[,] array = GetArray(row, columns, 0, 9);
PrintArray(array);

Console.WriteLine();

int[,] newArray = SelectionSort(array);
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


// int[,] ArrayInDescendingOrder (int[,] arr)
// {
//     int r = arr.GetLength(0);
//     int c = arr.GetLength(1); 
//     for(int i = 0; i <r; i++)
//     {
        
//         int k = arr[i,0];
//         for (int j = 0; j<c; j++)
//         {
//             int minPosition = j;
//             int m = 0;
//             if(arr[i,j] > arr[i,minPosition])
//             {
//                 minPosition = j;
//             }
//             m = arr[i,j];
//             arr[i,j] = arr[i,minPosition];
//             arr[i,minPosition] = m;
            
//         }
        
//     }
//     return arr;
// }

int[,] SelectionSort(int[,] array)
{
    int[,] arrayNew = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            int m = 0;

            for (int k = j+1; k < array.GetLength(1) ; k++)
            {
                
                if(array[i,k] < m) m = array[i,k];

            }
            arrayNew[i,minPosition] = m;
        }
    }
    return arrayNew;
}
