Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case < 10000:
    Console.WriteLine("число не пятизначное");
    break;
    case < 100000:
    int numbermem = number;
    int a = number % 10;
    number = number / 10;
    int b = number % 10;
    number = number / 10;
    int c = number % 10;
    number = number / 10;
    int d = number % 10;
    number = number / 10;
    int e = number % 10;
    if(a == e)
    {
        if(b == d)
        {
            Console.WriteLine("Является ли это число полиномом?");
            Console.WriteLine($"{numbermem} => да");
        }
        else
        {
            Console.WriteLine("Является ли это число полиномом?");
            Console.WriteLine($"{numbermem} => нет");
        }
    }
    else
    {
        Console.WriteLine("Является ли это число полиномом?");
        Console.WriteLine($"{numbermem} => нет");
    }
    break;
    default:
    Console.WriteLine("число не пятизначное");
    break;
}
