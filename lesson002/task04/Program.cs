int[] weight = { 5, 8, 7, 6, 9, 1, 3, 5, 6, 4, 8, 11, 15, 4, 3, 7, 14 };
int max = 0;

/*for (int i = 0; i < weight.Length; i++)
{
    if (weight[i] > max)
    {
        max = weight[i];
    }
    //Console.WriteLine("one cycle");
}
*/
foreach (int e in weight)
{
    if (e > max)
    {
        max = e;
    }
}
Console.Write(max);