string ReverseWords(string sample)
{
    string result="";
    char search_for=' ';
    int last_search_for_adress=sample.Length-1;
    for (int i=sample.Length-1;i>-1;i--)
    {
        if (sample[i]==search_for)
        {
            for (int j=i+1;j<last_search_for_adress;j++)
            {
                result+=sample[j];
            }
            result+=search_for;
            last_search_for_adress=i;
        }
    }
    for(int i=0;i<last_search_for_adress;i++)
    {
        result+=sample[i];
    }
    return result;
}
string StringToBeReversed ="Hello C# teacher, let me know if you check my code)))";
System.Console.WriteLine(StringToBeReversed);
System.Console.WriteLine(ReverseWords(StringToBeReversed));