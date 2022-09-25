// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = SpiralArray();
PrintArray(array);

int[,] SpiralArray()
{
    int[,] arr = new int[4,4];
    int count = 1;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
       arr[0,j] = count;
       count++;
    }
    for(int i = 1; i < arr.GetLength(0); i++)
    {
        arr[i, arr.GetLength(0) -1] = count;
        count++;
    }
    for(int j = arr.GetLength(1) -2; j >=0; j--)
    {
        arr[arr.GetLength(1) -1, j] = count;
        count++;
    }
    for(int i = arr.GetLength(0)-2; i >0; i--)
    {
        arr[i,0] = count;
        count++;
    }
    int c = 1;
    int d = 1;
    while (arr[c, d + 1] == 0) 
    {
        arr[c, d] = count;
        count++;
        d++;
    }
    while(arr[c + 1,d] == 0)
    {
        arr[c,d] = count;
        count++;
        c++;
    }
     while(arr[c,d-1] == 0)
    {
        arr[c,d] = count;
        count++;
        d--;
    }
     while(arr[c-1,d] == 0)
    {
        arr[c,d] = count;
        count++;
        c--;
    }
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            if (arr[i,j] == 0) 
            {
                arr[i,j] = count;
            }
        }
    }
    return arr;
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