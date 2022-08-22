// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Введите целое число");
int N=Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите целое число");
int M=Convert.ToInt32 (Console.ReadLine());


if (M<N)
{
    while (M<=N)
    {
        Console.Write($"{M} ");
        M++;
   
    }
}
else
{
    while (N<=M)
    {
        Console.Write($"{N} ");
        N++;
   
    }
}
