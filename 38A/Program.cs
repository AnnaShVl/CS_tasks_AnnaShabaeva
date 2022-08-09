// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int N=9;
double[] a=new double[N];
Init(out a,10,0,50);
Print(a);
Solve(a);

void Solve(double[] a)
{
double max=a[0];
double min=a[0];
for(int i=0;i<a.Length;i++)
    if (a[i]>max)
    {
    max=a[i];
    }
for(int i=0;i<a.Length;i++)
    if (a[i]<min)
    {
    min=a[i];
    }
System.Console.WriteLine($"максимальный элемент массива:{max}");
System.Console.WriteLine($"минимальный элемент массива:{min}");
double d=(max-min);
System.Console.WriteLine($"разница между максимальным и минимальным элементами массива:{d}");
}

void Init(out double[] a, int N,double min,double max)
{
    a=new double[N];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<N;i++)
            a[i]=random.NextDouble()*1000;
}

void Print(double[] a)
{
    for(int i=0;i<N;i++)
        System.Console.WriteLine($"{a[i],5}");
    System.Console.WriteLine();    
}

