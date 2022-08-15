// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] arr;//объявляем массив
arr = Create2DArray(3, 3);
Print(arr);
System.Console.WriteLine();
Solve(arr);


int[,] Create2DArray(int n, int m)
{
    int[,] a = new int[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = random.Next(0, 10);
    return a;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
    {
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}


void Solve (int[,] a)
{
    int sum=0;
    double avr;
   
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
        {
            for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
            {
                sum=sum+a[i,j];
            }
            avr=sum/(a.GetLength(1));
            System.Console.Write($"{avr,4}");
            sum=0;
        }
        
}

