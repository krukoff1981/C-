// вывести все четные числа до введенного числа
Console.WriteLine("Введите число");
string Number = Console.ReadLine();
int a = Convert.ToInt32(Number);
int count = 2;
int countprog = count;
if(a < count)
{
    Console.WriteLine("Здесь нет решений поставленной задачи");
}
else
    {
    Console.WriteLine("Полученный результат");
    Console.Write($"{a} -> ");
    
            while(countprog <= a - count)
        {
            Console.Write($"{countprog}, ");
            countprog = countprog + 2;
        }
        Console.WriteLine(countprog);
    }