// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите целое число");
int N=Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите целое число");
int M=Convert.ToInt32 (Console.ReadLine());

int sum=0;

if (M<N)
{
    while (M<=N)
    {
        sum=sum+M;
        M++; 
    }
    Console.WriteLine(sum);
}
else
{
    while (N<=M)
    {
        sum=sum+N;
        N++;
    }
    Console.WriteLine(sum);
}
