// из трех введенных чисел выдать максимальное
Console.WriteLine("Введите первое число");
string First = Console.ReadLine();
Console.WriteLine("Введите второе число");
string Second = Console.ReadLine();
Console.WriteLine("Введите третье число");
string Third = Console.ReadLine();
int a = Convert.ToInt32(First);
int b = Convert.ToInt32(Second);
int c = Convert.ToInt32(Third);
int max = a;
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.WriteLine($"{a} {b} {c} -> {max}");