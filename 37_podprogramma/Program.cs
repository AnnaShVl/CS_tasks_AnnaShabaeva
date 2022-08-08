// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int[] a;
Init(out a,6,100,1000);
Print(a);

int countEven, countOdd;
Solve(a,out countEven,out countOdd);

System.Console.WriteLine($"количество четных:{countEven}");
System.Console.WriteLine($"количество нечетных:{countOdd}");



void Solve(int[] a, out int countEven, out int countOdd)
{
  countEven=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2==0)
    {
        countEven=countEven+1;
    }
}

countOdd=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2!=0)
    {
        countOdd+=1;
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