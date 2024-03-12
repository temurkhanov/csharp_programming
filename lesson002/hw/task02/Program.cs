System.Console.WriteLine("Напишите координату Х:");
x_input:
int x = Convert.ToInt32(Console.ReadLine());
if (x==0)
{
    System.Console.WriteLine("Значение должно быть отлично от нуля (0). Пожалуйста, повторите ввод:");
    goto x_input;
}
System.Console.WriteLine("Напишите координату Y:");
y_input:
int y = Convert.ToInt32(Console.ReadLine());
if (y==0)
{
    System.Console.WriteLine("Значение должно быть отлично от нуля (0). Пожалуйста, повторите ввод:");
    goto y_input;
}
int quad = 1;
if (x > 0 && y > 0)
{ quad = 1; }
if (x < 0 && y > 0)
{ quad = 2; }
if (x < 0 && y < 0)
{ quad = 3; }
if (x > 0 && y < 0)
{ quad = 4; }
System.Console.WriteLine($"Точка находится в {quad}-й четверти координатной плоскости");