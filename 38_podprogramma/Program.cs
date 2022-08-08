//// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] a;
Init(out a,123,0,500);
Print(a);

int count;
Solve(a,out count);

System.Console.WriteLine($"количество элементов из отрезка[10,99]:{count}");



void Solve(int[] a, out int count)
{
  count=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]>=10&&a[i]<=99)
    {
        count=count+1;
    }
}
}

void Init(out int[] a,int Length=10,int min=0,int max=10)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1);
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();    
}