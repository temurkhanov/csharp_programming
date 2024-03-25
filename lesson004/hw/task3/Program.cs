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
int[] TurnOverMatrix(int[] sample_matrix)
{
    int[] new_matrix=new int[sample_matrix.Length];
    for(int i=0;i<sample_matrix.Length;i++)
    {
        new_matrix[i]=sample_matrix[sample_matrix.Length-1-i];
    }
    return new_matrix;
}
int size = Convert.ToInt32(Console.ReadLine());
int[] matrix= new int[size];
FillMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(TurnOverMatrix(matrix));