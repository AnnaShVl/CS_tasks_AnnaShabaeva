// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N=4;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,11);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

int sum=0;
for(int i=1;i<a.Length;i=i+2)
    //sum+=a[i];
    sum=sum+a[i];
System.Console.WriteLine();
System.Console.WriteLine(sum);
