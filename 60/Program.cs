// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] genRandArray(int firstDim, int secondDim, int thirdDim)
{
    int[,,] array = new int[firstDim, secondDim, thirdDim];
    Random randy = new Random();
    for (int i = 0; i < firstDim; i++)
        for (int j = 0; j < secondDim; j++)
            for (int k = 0; k < thirdDim; k++) array[i, j, k] = randy.Next(0, 9);

    return array;
}
void printArrayMod(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j,k]}({i},{j},{k})");
            }
             Console.WriteLine();
    }
}
printArrayMod(genRandArray(2,2,2));