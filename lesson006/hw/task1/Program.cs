string FillStringWith2dArrayElements(char[,] sample_array, string res_string)
{
    for (int i = 0; i < sample_array.GetLength(0); i++)
    {
        for (int j = 0; j < sample_array.GetLength(1); j++)
        {
            res_string += sample_array[i, j];
        }
    }
    return res_string;
}
char[,] char_array = {{ 'a', 'b', 'c', 'd', 'e', 'f' },{'g', 'h', 'i', 'j', 'k', 'l'}};
string print_string="";
System.Console.WriteLine(FillStringWith2dArrayElements(char_array, print_string));