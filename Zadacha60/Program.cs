// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] array = GetArray(2, 2, 2);
PrintArray(array);

int[,,] GetArray(int m, int n, int l)
{
    
    int[,,] result = new int[m, n, l];
    result[0,0,0] = new Random().Next(10,21);
    int r = result[0,0,0];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            for(int e = 0; e<l; e++)
            {   

                result[i,j,e] = new Random().Next(1,10) + r;
                r = result[i,j,e];
            }
        }
    }
    return result;
}

// int[,,] GetArray(int m, int n, int l)
// {
//     int[,,] result = new int[m, n, l];
//     foreach(int rand in result)
//     {
//         result[0,0,0] = new Random().Next(10,21);
//         int r = result[0,0,0];
//         while(m < result.GetLength(0) && n <result.GetLength(1) && l < result.GetLength(2))
//         {
//             result[m,n,l] = new Random().Next(1,10) + r;
//             r = result[m,n,l];
//         }
//     }
//     return result;
// }

void PrintArray(int[,,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            for(int e = 0; e<inArray.GetLength(2); e++)
            {
                Console.Write($"{inArray[i,j,e]} ({i},{j},{e}) ");
            }
            Console.WriteLine();
        }
        
    }
    
}