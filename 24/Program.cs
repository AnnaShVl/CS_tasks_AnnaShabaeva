// Вывести на экран таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите целое число");
int N=Convert.ToInt32 (Console.ReadLine());

int a, b;
a=1;
b=1;

while (a<=N)
{
    b=a*a;
    a++;
     Console.Write($"{b} ");
}


