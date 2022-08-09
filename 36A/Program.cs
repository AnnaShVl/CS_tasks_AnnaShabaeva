// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] a;
Init(out a,6,1,10);
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

void Init(out int[] a,int N,int min,int max)
{
    a=new int[N];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max);
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();    
}
