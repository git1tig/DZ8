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
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) != arr2.GetLength(0))

    {
        Console.WriteLine("Неподходящие размеры матриц!!! ");
    }

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            for (int s = 0; s < arr2.GetLength(0); s++)
            {
                result[i, j] = result[i, j] + arr1[i, s] * arr2[s, j];
                // Console.WriteLine($"Умножаем {arr1[i, s]} на {arr2[s, j]}");
                // Console.WriteLine($"Теперь res({i},{j}) = {result[i, j]} i={i}, j= {j}? s={s}");
            }
        }

    }
    return result;
}

int[,] arrA = genRandArray(2, 2);
int[,] arrB = genRandArray(2, 2);
Console.WriteLine("Матрица1:");
Console.WriteLine();
printArray(arrA);
Console.WriteLine();
Console.WriteLine("Матрица2:");
Console.WriteLine();
printArray(arrB);
Console.WriteLine();
Console.WriteLine("Результат умножения:");
Console.WriteLine();
printArray(matrixMultiply(arrA, arrB));
Console.WriteLine();
