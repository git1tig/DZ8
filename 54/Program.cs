// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] genRandArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random randy = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++) array[i, j] = randy.Next(0, 20);

    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

int[,] sortArray(int[,] arr)

{
    int k=0;
    int tmp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            k=0;
            while(k<arr.GetLength(1)-1)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    tmp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = tmp;
                    
                }
                k++;
            }
        }


    }
    return arr;
}

int[,] myArray = genRandArray(3, 8);
printArray(myArray);
Console.WriteLine();
int[,] reverseArr = sortArray(myArray);
printArray(reverseArr);

