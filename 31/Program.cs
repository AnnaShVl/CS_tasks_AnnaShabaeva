// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите целое число");
int N=Convert.ToInt32 (Console.ReadLine());

int a, b;
a=1;
b=1;

while (a<=N)
{
    b=a*a*a;
    a++;
    if (b%2==0)
    {
        Console.Write($"{b} ");
    }  
}