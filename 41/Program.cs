// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


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
