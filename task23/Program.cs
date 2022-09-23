// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int n = 0;
Console.WriteLine("Таблица кубов:");
while (n < N)
{
    n++;
    int a = n * n * n;
    Console.WriteLine(a);
}


