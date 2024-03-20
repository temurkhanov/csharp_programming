void PrintSquares(int n)
{
    for (int i=0; i<n; i++)
    {
        Console.Write(i*i + " ");
    }
    Console.WriteLine();
}
PrintSquares(new Random().Next(1,10));
PrintSquares(new Random().Next(1,10));
PrintSquares(new Random().Next(1,10));