void PrintReversedArray (int [] input_array)
{
    if (input_array.Length==1)
    {
        Console.Write(input_array[0]);
        return;
    }
    Console.Write(input_array[input_array.Length-1] + " ");
    Array.Resize(ref input_array, input_array.Length-1);
    PrintReversedArray(input_array);
}
int[] sample_array = [1,2,3,4,5,6,7];
PrintReversedArray(sample_array);