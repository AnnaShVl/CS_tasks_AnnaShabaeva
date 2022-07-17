// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=10;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(100,1000);
}
int countEven=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2==0)
    {
        countEven=countEven+1;
    }
}

int countOdd=0;
for(int i=0;i<a.Length;i++)
{
    if (a[i]%2!=0)
    {
        countOdd+=1;
    }
}

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();
System.Console.WriteLine($"количество четных:{countEven}");
System.Console.WriteLine($"количество нечетных:{countOdd}");
