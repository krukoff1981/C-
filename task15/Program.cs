// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// Эту задачу решу способом сравнения введенного числа и условных обозначений дней недели

Console.WriteLine("Даны дни недели");
Console.WriteLine("Понедельник - 1");
Console.WriteLine("Вторник - 2");
Console.WriteLine("Среда - 3");
Console.WriteLine("Четверг - 4");
Console.WriteLine("Пятница - 5");
Console.WriteLine("Суббота - 6");
Console.WriteLine("Воскресенье - 7");
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    if(number<6)
    {
        Console.WriteLine("Этот день - выходной?");
        Console.WriteLine($"{number} -> нет");
    }
    else
    {  
        if(number<8)
        {
            Console.WriteLine("Этот день - выходной?");
        Console.WriteLine($"{number} -> да");
        }
        else
        {
            Console.WriteLine("Вы ввели неверное число");
        }
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
