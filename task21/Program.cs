// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int [] firstArray = new int[3];
int [] secondArray = new int[3];
int summ = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} коордитату точки один");
    firstArray[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < secondArray.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} коордитату точки два");
    secondArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Расстояние между точками составляет ");
for (int i = 0; i < firstArray.Length; i++)
{
    summ = summ + (firstArray[i] - secondArray[i]) * (firstArray[i] - secondArray[i]);
}
double result = Math.Sqrt(summ);
Console.WriteLine(result);
