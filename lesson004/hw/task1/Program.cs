int GetSumOfDigits(int num)
{
    int sum=0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
bool IsSumEven(int data)
{
    if(GetSumOfDigits(data)%2==0)
    {
        return true;
    }
    return false;
}
while (true)
{
    Console.WriteLine("Please, enter integer number(s):");
    string InputStr = Console.ReadLine();
    if (InputStr == "q" || IsSumEven(Convert.ToInt32(InputStr)))
    {
        break;
    }
}
