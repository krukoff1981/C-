// Определить четность введенного числа
Console.WriteLine("Введите число");
string Number = Console.ReadLine();
int Num = Convert.ToInt32(Number);
Console.WriteLine("число четное?");
if(Num == 0)
{
    Console.WriteLine("0 не является числом для определения четности");
}
else
{
    if(Num % 2 == 0)
    {
        Console.WriteLine($"{Number} -> да");
    }
    else
    {
        Console.WriteLine($"{Number} -> нет");
    }
}