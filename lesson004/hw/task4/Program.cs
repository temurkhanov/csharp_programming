void Fill2xMatrix(int[,] sample_matrix)
{
    for (int i = 0; i < sample_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < sample_matrix.GetLength(1); j++)
        {
            sample_matrix[i, j] = new Random().Next(0, 21);
        }
    }
}
void Print2xMatrix(int[,] print_matrix)
{
    for (int i = 0; i < print_matrix.GetLength(0); i++)
    {
        Console.Write("[\t");
        for (int j = 0; j < print_matrix.GetLength(1); j++)
        {
            Console.Write(print_matrix[i, j] + "\t");
        }
        Console.WriteLine("]");
    }
}
int GetIntNumFromConsole()
{
    int ret_int;
    System.Console.WriteLine("Enter Integer Number:");
    ret_int = Convert.ToInt32(Console.ReadLine());
    return ret_int;
}
int[,] DeleteRowAndCol(int row_num, int col_num, int[,] target_matrix)
{
    int[,] result = new int[target_matrix.GetLength(0) - 1, target_matrix.GetLength(1) - 1];
    int a = 0;
    int b = 0;
    for (int i = 0; i < target_matrix.GetLength(0); i++)
    {
        if ( i!=row_num )
        {
        if (i > row_num)
        {
            a = i - 1;
        }
        else
        {
            a = i;
        }
        for (int j = 0; j < target_matrix.GetLength(1); j++)
        {
            if (j!=col_num)
                {
            if (j > col_num)
            {
                b = j - 1;
            }
            else
            {
                b = j;
            }
            result[a, b] = target_matrix[i, j];
        }
    }
}
    }
    return result;
}
bool CheckIfRowExists(int row_num, int[,] check_matrix)
{
    if (row_num < check_matrix.GetLength(0))
    {
        return true;
    }
    return false;
}
bool CheckIfColExists(int col_num, int[,] check_matrix)
{
    if (col_num < check_matrix.GetLength(1))
    {
        return true;
    }
    return false;
}

int row_count = GetIntNumFromConsole();
int col_count = GetIntNumFromConsole();
int[,] matrix = new int[row_count, col_count];
Fill2xMatrix(matrix);
Print2xMatrix(matrix);
System.Console.WriteLine("Enter row and coloumn numbers, respectively, that should be deleted.");
int del_row_num = GetIntNumFromConsole();
int del_col_num = GetIntNumFromConsole();
if (CheckIfColExists(del_col_num, matrix) && CheckIfRowExists(del_row_num, matrix))
{
    Print2xMatrix(DeleteRowAndCol(del_row_num, del_col_num, matrix));
}
else
{
    System.Console.WriteLine("Incorrect input!!!");
}

    
        
