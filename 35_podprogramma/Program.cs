// Написать программу замены элементов массива на противоположные

int[] a;
Init(out a,12,-9,9);
Print(a);

Solve(a);

Print(a);



void Solve(int[] a)
{
    for(int i=0;i<a.Length;i++)
{
    a[i]=-a[i];
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