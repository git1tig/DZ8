// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] genRandArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    Random randy = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++) array[i, j] = randy.Next(0, 9);

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

int[,] matrixMultiply(int[,] arr1, int[,] arr2)
{
    int maxDim = 0;
    int strMoreCols=0;
    int colsMoreStr=0;
    int dif=0;
    if (arr1.GetLength(0) != arr2.GetLength(1) || arr1.GetLength(1) != arr2.GetLength(0))
    {
         Console.WriteLine("Неподходящие размеры матриц!");

    }
    if (arr1.GetLength(0) > arr1.GetLength(1)) maxDim = arr1.GetLength(0);
    else maxDim = arr1.GetLength(1);
    int[,] result = new int[arr1.GetLength(1), arr2.GetLength(0)];   


    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            for (int s = 0; s < maxDim; s++)
            {
                result[i, j] = result[i, j] + arr1[i, s] * arr2[s, j];
                Console.WriteLine($"Умножаем {arr1[i, s]} на {arr2[s, j]}");
                Console.WriteLine($"Теперь res({i},{j}) = {result[i, j]} i={i}, j= {j}? s={s}");
            }
        }

    }
    return result;
}

int[,] arrA = genRandArray(2, 3);
int[,] arrB = genRandArray(3, 2);
printArray(arrA);
Console.WriteLine();
printArray(arrB);
printArray(matrixMultiply(arrA, arrB));
