// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


int N=8;
int[] a=new int[N];


//Ввод данных
Init(a,N);

Print(a);

//инициализация данных
void Init(int[] a,int Length)
{
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(0,2);
}


//Вывод результатов
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
}


