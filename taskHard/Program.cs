// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа,
//необходимо вывести максимальную цифру в полученном округлённом значении площади круга

Console.Write("Введите радиус круга: ");
int number = Convert.ToInt32(Console.ReadLine());
int area = Convert.ToInt32(number * number * Math.PI);
Console.Write("Площадь круга: ");
Console.WriteLine(area);
int max = 0;
while (area > 9)
{
    if (area % 10 > max)
    {    
        max = area % 10;
    }
    area = area / 10;
}
if (area > max)
{
    max = area;
}
Console.Write("Максимальная цифра в этом числе: ");
Console.WriteLine(max);