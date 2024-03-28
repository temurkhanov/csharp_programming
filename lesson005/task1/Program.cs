int FindFactorialOfN(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    return n *= FindFactorialOfN(n - 1);
}
System.Console.WriteLine("Please enter integer number:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindFactorialOfN(number));