// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
//int i = 0;
int degree = 1;
//while(i < b)
//{
  //  degree = degree * a;
  // i++;
//}

for(int i = 0; i < b; i++)
{
    degree = degree * a;
}

Console.WriteLine($"{a},{b} -> {degree}");