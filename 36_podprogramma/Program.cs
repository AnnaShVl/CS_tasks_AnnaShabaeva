//Определить, присутствует ли в заданном массиве, некоторое число

System.Console.WriteLine("введите число");
int number;
string? s;
s=Console.ReadLine();
number=Convert.ToInt32(s);
int[] a;
Init(out a,10,0,10);
Print(a);
int j;
Solve(a,out j);



void Solve(int[] a, out int j)
{
  j=0;
while (j<a.Length && a[j]!=number) j++;
if (j==a.Length) System.Console.WriteLine("No");
else System.Console.WriteLine($"Yes. {j}");;
}



void Init(out int[] a,int Length,int min,int max)
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