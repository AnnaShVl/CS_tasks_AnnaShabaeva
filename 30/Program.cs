// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите целое число");
int N=Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine(Factorial(N));

int Factorial(int N)//8-17 строки-подпрограмма
{
    int f=1, a=1;
    while(a<=N)
    {
        f=f*a;
        a++;        
    }
    return f;
}
