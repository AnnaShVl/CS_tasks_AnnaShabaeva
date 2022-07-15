//Задать массив из 8 целых элементов и вывести их на экран
/*int N=8;
int[] a=new int[N];
for(int i=0;i<a.Length;i++)
    a[i]=1;
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");*/

//Задать массив из 8 целых элементов и вывести их на экран
int N=8;
int[] a=new int[N];
Random random=new Random();
//Random random=new Random(100);
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,100);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
