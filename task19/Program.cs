Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case < 10000:
    Console.WriteLine("число не пятизначное");
    break;
    case < 100000:
    if(number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        Console.WriteLine("Является ли это число полиномом?");
        Console.WriteLine($"{number} => да");
    }
    else
    {
        Console.WriteLine("Является ли это число полиномом?");
        Console.WriteLine($"{number} => нет");
    }
    break;
    default:
    Console.WriteLine("число не пятизначное");
    break;
}
