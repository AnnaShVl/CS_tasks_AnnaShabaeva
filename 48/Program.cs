//  Написать программу копирования массива

int N=8;
int[] arra=new int[N];
Init(arra,N);
Print(arra);
int[] arrb=new int[N];
CopyArray(arrb);
Print(arrb);

void CopyArray(int[] arrb)
{
     for(int i=0;i<arrb.Length;i++)
            arrb[i]=arra[i];
            
}

void Init(int[] a,int N)
{
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(0,11);
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
        System.Console.WriteLine();
}

