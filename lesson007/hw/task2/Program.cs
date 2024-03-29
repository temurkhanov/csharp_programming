// Стек переполняется при некоторых значениях m и n, хотел оптимизировать код что бы он мог
// обрабатывать все значения но не смог найти понятное объснение функции в интернете.
// По контексту тех результатов которых я нашел, понятно, что при больших значениях вводимых данных,
// расчет результата по этой формуле аккермана будет занимать все больше памяти и вычислительной
// мощности. По этой причине не стал дальше заморачиваться, так как, если это так, то это функция и 
// придумана что бы испытать компьютер и переаолнение стека это норма.
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return n + 1;
}
int PosIntegerInput()
{
    int int_num;
int_input:
    System.Console.WriteLine("enter positive integer number");
    int_num = int.Parse(Console.ReadLine());
    if (int_num < 0)
    {
        System.Console.WriteLine("! number is not positive");
        goto int_input;
    }
    return int_num;
}
int first_num = PosIntegerInput();
int second_num = PosIntegerInput();
System.Console.WriteLine(Ackermann(first_num, second_num));