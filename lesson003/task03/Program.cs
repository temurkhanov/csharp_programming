void ZeroEvenEl(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
ZeroEvenEl(a);
for (int i=0;i<a.Length;i++)
{
    Console.Write(a[i] + " ");
}