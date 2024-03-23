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
bool IsInteresting(int num)
{
    bool IsInteresting=false;
    if (num%2==0)
    {
        IsInteresting=true;
    }
    return IsInteresting;
}
int InterestingNumCount(int [,] check_matrix)
{
    int count=0;
    for (int i=0; i<check_matrix.GetLength(0); i++)
    {
        for (int j=0;j<check_matrix.GetLength(1);j++)
        {
            if (IsInteresting(check_matrix[i,j]))
            {
                count++;
            }
        }
    }
    return count;
}
int[,] sample_matrix=fill_matrix(4,5);
print_matrix(sample_matrix);
Console.Write(InterestingNumCount(sample_matrix));