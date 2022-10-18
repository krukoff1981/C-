// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] numb = new int[10];
Random rdm = new Random();
for (int i = 0; i < numb.Length; i++)
{
    numb[i] = rdm.Next(-10, 101);
}

int sum = 0;
for (int i = 1; i < numb.Length; i += 2)
{
    sum = sum + numb[i];
}
Console.Write("[ ");
for (int i = 0; i < numb.Length; i++)
{
    if (i < numb.Length - 1)

        Console.Write(numb[i] + ", ");
    else
    {
        Console.Write(numb[i]);
    }
}

Console.WriteLine(" ]");
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);