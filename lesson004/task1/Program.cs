int[,] fill_matrix(int row, int col)
{
    int[,] some_matrix= new int[row, col];
    for (int i=0; i<row; i++)
    {
        for (int j=0;j<col;j++)
        {
            some_matrix[i,j]=new Random().Next(0,9);
        }
    }
    return some_matrix;
}
void print_matrix(int[,] print_matrix)
{
    for (int i=0;i<print_matrix.GetLength(0);i++)
    {
        for (int j=0; j<print_matrix.GetLength(1);j++)
        {
            Console.Write($"{print_matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
int[,] sample_matrix=fill_matrix(4,5);
print_matrix(sample_matrix);