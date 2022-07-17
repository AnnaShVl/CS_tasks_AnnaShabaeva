//Определить, присутствует ли в заданном массиве, некоторое число

int N=10;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
}
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
    System.Console.WriteLine();

int number=8;
//a[1]=number;
//Алгоритм линейного поиска
int j=0;
while (j<a.Length && a[j]!=number) j++;
if (j==a.Length) System.Console.WriteLine("No");
else System.Console.WriteLine($"Yes. {j}");;