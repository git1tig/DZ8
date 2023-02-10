
int n=0;
Console.Write("Введите N:");
while (!Int32.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}
int cursorXpos=(n+1)/2+1;
int cursorYpos=(Console.CursorTop);
Console.SetCursorPosition(cursorXpos, cursorYpos);
Console.Write("1");
cursorYpos++;

for (int i=1; i<=n;i++)
{
    int[] arr=new int[i+1]
    int[] temparr= new int[i+2]

    for (int j=0; j<i+3; j++)
    {
        int cursorXpos--;      
        Console.SetCursorPosition(cursorXpos, cursorYpos);
        Console.Write()

    }



}


