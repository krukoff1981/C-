// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int i = 0;

for(i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число с индексом {i} \t");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

i = 0;
while(i < array.Length-1)
{
    Console.Write($"{array[i]}, ");
    i++;
}
Console.Write($"{array[i]} -> [");

i = 0;
while(i < array.Length-1)
{
    Console.Write($"{array[i]}, ");
    i++;
}
Console.WriteLine($"{array[i]}]");