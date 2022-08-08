// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] a;
Init(out a,6,1,30);
Print(a);
int sum;
Solve(a,out sum);

void Solve(int[] a,out int sum)
{
    sum=0;
    for(int i=1;i<a.Length;i=i+2)
    sum=sum+a[i];
System.Console.WriteLine();
System.Console.WriteLine(sum);
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


