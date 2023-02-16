// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arr = new int[7, 3];
int bigNum = arr.GetLength(0) * arr.GetLength(1);
int lastStr = 0;
int lastCol = 0;
int strMax = arr.GetLength(0);
int colMax = arr.GetLength(1);
bool rowFwd = true;
bool nowRow = true;
bool colFwd = true;
int strPos = 0;
int colPos = 0;
int strCount = 1;
int colCount = 1;
int strSteps = 0;
int colSteps = 0;
for (int i = 1; i <= bigNum; i++)
{
    if (nowRow)
    {
        arr[strPos, colPos] = i;

        if (rowFwd) colPos++;
        else colPos--;

        strSteps++;

        if (strSteps > colMax - colCount)
        {
            lastCol = colPos;
            colCount++;
            if (rowFwd) strPos++;
            else strPos--;
            if (rowFwd) colPos--;
            else colPos++;
            rowFwd = !rowFwd;
            nowRow = false;
            strSteps = 0;
        }

    }
    else
    {
        arr[strPos, colPos] = i;

        if (colFwd) strPos++;
        else strPos--;

        colSteps++;

        if (colSteps >= strMax - strCount)
        {
            if (colFwd) strPos--;
            else strPos++;
            if (colFwd) colPos--;
            else colPos++;
            nowRow = true;
            colFwd = !colFwd;
            lastStr = strPos;
            strCount++;
            colSteps = 0;
        }

    }

}


void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + "\t");
        Console.WriteLine();
        Console.WriteLine();
    }
}

printArray(arr);

