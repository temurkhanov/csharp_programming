void PrintReversedFrom (int[] input_array, int address)
//function to print elements of array reversed from input address
{
    if (address==-1)
    {
        return;
    }
    Console.Write(input_array[address]+" ");
    PrintReversedFrom(input_array, address-1);

}
int[] sample_matrix= [1,2,3,4,5,6,7];
PrintReversedFrom(sample_matrix, sample_matrix.Length-1);