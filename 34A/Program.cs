/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.


Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/


int[] a;
Init(out a,10,100,1000);
Print(a);
int countEven;
Solve(a,out countEven);
System.Console.WriteLine($"количество четных:{countEven}");


void Solve(int[] a, out int countEven)
{
  countEven=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2==0)
    {
        countEven=countEven+1;
    }
}   
}    

void Init(out int[] a,int N,int min,int max)
{
    a=new int[N];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<N;i++)
            a[i]=random.Next(min,max);
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();    
}
