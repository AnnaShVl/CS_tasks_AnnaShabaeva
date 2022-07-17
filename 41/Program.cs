// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

/*int N=9;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();

int max=a[0];
int min=a[0];
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

System.Console.WriteLine(max);
System.Console.WriteLine(min);

int d=(max-min);
System.Console.WriteLine(d);*/

/*double[,] a = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}*/

int N=9;
double[] a=new double[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.NextDouble()*100;

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],20}");
    System.Console.WriteLine();

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

System.Console.WriteLine(max);
System.Console.WriteLine(min);

double d=(max-min);
System.Console.WriteLine(d);
