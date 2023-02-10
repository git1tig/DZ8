

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

void printstrArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " \t ");
        Console.WriteLine();
    }
}


string[,] elementsStat(int[,] array)
{
    string[,] vocab = new string[2, array.GetLength(0) * array.GetLength(1)];
    int busyIndex = 0;
    bool isInVoc = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < vocab.GetLength(1); k++)
            {
                if (Convert.ToString(array[i, j]) == vocab[0, k])
                {
                    vocab[1, k] = Convert.ToString(Convert.ToInt32(vocab[1, k]) + 1);
                    isInVoc = true;
                  //  Console.WriteLine("Совпадение! " + array[i,j]);
                   
                }
                // Console.WriteLine(" * i=" + i + " * j="+ j + "*k=" + k + "* busy=" + busyIndex + " isivoc "+ isInVoc);
                 
            }
            if (!isInVoc)
            {
                vocab[0, busyIndex] = Convert.ToString(array[i, j]);
                vocab[1, busyIndex] = "1";
                //Console.WriteLine("новый элеменn " + array[i,j] + " под индексом " + busyIndex);
                busyIndex++;
                //isInVoc = false;
                
            }

        }
        isInVoc =false;

    }
    return vocab;
}

int[,] myArray = genRandArray(5, 5);

printArray(myArray);
Console.WriteLine();
Console.WriteLine();
string[,] resultArr = elementsStat(myArray);
Console.WriteLine();

printstrArray(resultArr);



