void PrintBetweenMN(int m, int n)
{
    if (m == n - 1)
    {
        return;
    }
    System.Console.Write($"{m + 1} ");
    PrintBetweenMN(m + 1, n);
}
int IntegerInput()
{
    System.Console.WriteLine("enter integer number");
    int int_num = Convert.ToInt32(Console.ReadLine());
    return int_num;
}
int first_num = IntegerInput();
int second_num = IntegerInput();
if (first_num < second_num)
{
    PrintBetweenMN(first_num, second_num);
}
else
{
    PrintBetweenMN(second_num, first_num);
}