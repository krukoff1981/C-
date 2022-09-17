// вывести все четные числа до введенного числа
int a = 16;
int count = 2;
int countprog = count;
if(a < count)
{
    Console.WriteLine(0);
}
else
{
    while(countprog <= a - count)
    {
        Console.Write($"{countprog}, ");
        countprog = countprog + 2;
    }
    Console.WriteLine(countprog);
}