
void FillMatrix(int[] sample_matrix)
{
    for(int i=0;i<sample_matrix.Length;i++)
    {
        sample_matrix[i]=new Random().Next(100,1000);
    }
}
void PrintMatrix(int[] print_matrix)
{
    Console.Write("[ ");
    for(int i=0;i<print_matrix.Length;i++)
    {
        Console.Write(print_matrix[i] + " ");
    }
    Console.WriteLine("]");
}
bool IsEven(int num)
{
    if(num%2==0)
    {
        return true;
    }
    return false;
}
void PrintHowManyEvenElements(int[] sample_matrix)
{
    int even_elements_count=0;
    for(int i=0;i<sample_matrix.Length;i++)
    {
        if(IsEven(sample_matrix[i]))
        {
            even_elements_count++;
        }
    }
    Console.WriteLine($"There are {even_elements_count} even elements in current matrix");
}
int size = Convert.ToInt32(Console.ReadLine());
int[] matrix= new int[size];
FillMatrix(matrix);
PrintMatrix(matrix);
PrintHowManyEvenElements(matrix);