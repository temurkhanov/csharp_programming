double CalculateFor(int a, int b, int c, int d)
{
    int numerator = a*b;
    double denominator =c+d;
    double result = numerator/denominator;
    return result;
}
Console.Write(CalculateFor(new Random().Next(1,10),new Random().Next(1,10),new Random().Next(1,10),new Random().Next(1,10)));