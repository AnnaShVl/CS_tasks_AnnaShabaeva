// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры


System.Console.WriteLine("введите число");
int N;
string? s;
s=Console.ReadLine();//просит ввести число
N=Convert.ToInt32(s);//преобразует формат числа в int
int[] a;
Init(out a,N);
Print(a);
int count;
Solve(a,out count);


void Solve(int[] a,out int count)
{
    count=0;
    for(int i=0;i<a.Length;i=i+1)
    {
    if (a[i]>0)
        count=count+1;
    }
   
System.Console.WriteLine();
System.Console.WriteLine(count);
}

void Init(out int[] a,int N,int min=-10,int max=10)
{
    a=new int[N];
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



