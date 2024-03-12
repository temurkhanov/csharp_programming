System.Console.WriteLine("Введите натуральное число");
n_input:
int n = Convert.ToInt32(Console.ReadLine());
if (n<0)
{
    System.Console.WriteLine("Число не натуральное. Повторите ввод:");
    goto n_input;
}
while (n>0)
{
    int res = n%10;
    n=n/10;
    System.Console.WriteLine(res + ",");
}