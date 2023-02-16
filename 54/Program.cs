// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// *****************************************
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] genRandArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random randy = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++) array[i, j] = randy.Next(0, 10);

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

int minArrStringSum(int[,] arr)
{
    int[] sums = new int[arr.GetLength(0)];
    int sum = 0;
    int sumPrev = 0;
    int strMin = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sumPrev == 0) sumPrev = sum;
        if (sum < sumPrev)
        {
            strMin = i;
            sumPrev = sum;
        }
        sum = 0;

    }
    return strMin + 1;
}

int[,] sortArray(int[,] arr)
{
    int k = 0;
    int tmp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            k = 0;
            while (k < arr.GetLength(1) - 1)
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

int[,] myArray = genRandArray(3, 3);
Console.WriteLine("Генерируем массив..");
printArray(myArray);
Console.WriteLine("Сортируем элементы в строчках...");
int[,] reverseArr = sortArray(myArray);
printArray(reverseArr);
Console.WriteLine();
Console.WriteLine($"Строчка с наименьшей суммой: {minArrStringSum(myArray)}");


