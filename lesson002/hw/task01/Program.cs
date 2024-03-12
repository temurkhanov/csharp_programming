System.Console.WriteLine("Напишите число:");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Кратность 7: ");
if (num%7 == 0)
{
    System.Console.WriteLine("+");
}
else
{
    System.Console.WriteLine("-");
}
System.Console.Write("Кратность 23: ");
if (num%23 == 0)
{
    System.Console.WriteLine("+");
}
else
{
    System.Console.WriteLine("-");
}