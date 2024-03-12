System.Console.WriteLine("Напишите десятичное число:");
num_input:
int num = Convert.ToInt32(Console.ReadLine());
if (num<10 || num>99)
{
    System.Console.WriteLine("Число не десятичное. Повторите ввод:");
    goto num_input;
}
int num1 = num/10;
int num2 = num%10;
if (num1>=num2)
{
    if (num1==num2)
    {
        System.Console.WriteLine($"Цифры равны: {num1}");
    }
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}