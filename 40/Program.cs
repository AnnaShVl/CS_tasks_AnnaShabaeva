//Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
//Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N=9;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

int[] b=new int[N/2];

for(int i=0;i<a.Length/2;i++)
    b[i]=a[i]*a[a.Length-1-i];

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();
for(int i=0;i<b.Length;i++)
    System.Console.Write($"{b[i],4}");
System.Console.WriteLine();

