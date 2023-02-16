// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] genRandArrayUniq(int firstDim, int secondDim, int thirdDim)
{
    int[,,] array = new int[firstDim, secondDim, thirdDim];
    int[] voc = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];  // типа список того, что уже было
    Random randy = new Random();
    bool nonUniq = false;  
    int tempy = 0;
    int vocIndex = 0; // индекс словаря текущий
    int vocLength = 0; //длина словаря, что бы не перебирать лишнее
    for (int i = 0; i < firstDim; i++)
        for (int j = 0; j < secondDim; j++)
            for (int k = 0; k < thirdDim; k++)
            {
                //Console.WriteLine($"Working on ({i},{j},{k})");  //debug
                nonUniq = true;
                while (nonUniq)
                {
                    tempy = randy.Next(1, 9);
                    //Console.WriteLine($"tempy= {tempy}");  //debug
                    if (vocLength == 0)
                    {
                        array[i, j, k] = tempy;
                        voc[0] = tempy;
                        vocLength++;
                        vocIndex++;                      
                        break;
                    }
                    nonUniq = false;
                    for (int n = 0; n < vocLength; n++)
                    {
                        if (tempy == voc[n])
                        {
                            nonUniq = true;
                            break;
                        }
                        //Console.Write($"tempy={tempy}, voc[{n}]={voc[n]}, tempy == voc[n] {tempy == voc[n]} nonunic={nonUniq} \n"); //debug
                    }
                    if (!nonUniq)
                    {
                        voc[vocIndex] = tempy;
                        vocIndex++;
                        vocLength++;
                        array[i, j, k] = tempy;
                    }
                }
            }


    return array;
}
void printArrayMod(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]}({i},{j},{k})");
            }
        Console.WriteLine();
    }
}
printArrayMod(genRandArrayUniq(2, 2, 2));