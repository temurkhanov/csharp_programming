string FillStringWithLength (int result_length)
{
    int i=0;
    int j=0;
    int random_num;
    string symbol_string = " 1234567890!@#$%^&*()_+=-<>?|'[{}]qwertyuiopasdfghjklzxcvbnm";
    string result="";
    while (i<result_length)
    {
        random_num=new Random().Next(0, symbol_string.Length);

        if (i>symbol_string.Length)
        {
            j=i-symbol_string.Length;
        }
        result+=symbol_string[random_num];
        i++;
        j++;
    }
    return result;
}
bool IsStringPalindrome (string sample)
{
    for (int i=0;i<sample.Length/2;i++)
    {
        if (sample[i]!=sample[sample.Length-1-i])
        {
            return false;
        }
    }
    return true;
}
string for_check = "123";
System.Console.WriteLine("Enter string length (integer number):");

for_check=FillStringWithLength(Convert.ToInt32(Console.ReadLine()));
//for_check=FillStringWithLength(3);
System.Console.WriteLine(for_check);
if (IsStringPalindrome(for_check))
{
    System.Console.WriteLine("String is palindrome)");
}
else
{
    System.Console.WriteLine("String is not palindrome(");
}
