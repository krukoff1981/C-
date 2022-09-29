// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите произвольное число");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;
for(int a = number; a > 0; a = a / 10)
{
    summ = summ + a % 10;
}
Console.WriteLine($"{number} -> {summ}");