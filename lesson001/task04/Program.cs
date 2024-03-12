int a = 0;
int b = 4;
int c = 5;
int d = 23;
int e = 9;

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
if (max < d)
{
    max = d;
}
if (max < e)
{
    max = e;
}
Console.WriteLine(max);