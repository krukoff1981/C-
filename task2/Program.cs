// из двух введенных чисел указать какое из них max, а какое min
Console.WriteLine("введите число a");
string First = Console.ReadLine();
Console.WriteLine("введите число b");
string Second = Console.ReadLine();
int FirstNum = Convert.ToInt32(First);
int SecondNum = Convert.ToInt32(Second);
if(FirstNum == SecondNum)
{
    Console.WriteLine("вы ввели:");
    Console.WriteLine($"число a {FirstNum}");
    Console.WriteLine($"число b {SecondNum}");
    Console.WriteLine("Числа равны");
}
else
{
    if(FirstNum > SecondNum)
    {
        Console.Write($"a = {First}; b = {Second} -> ");
        Console.WriteLine($"max = {First}; min = {Second}");
    }
    else
    {
        Console.Write($"a = {First}; b = {Second} -> ");
        Console.WriteLine($"max = {Second}; min = {First}");
    }
}