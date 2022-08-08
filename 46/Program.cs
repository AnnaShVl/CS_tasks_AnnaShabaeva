// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.WriteLine("введите число");
int N;
string? s;
s=Console.ReadLine();//просит ввести число
N=Convert.ToInt32(s);//преобразует формат числа в int
Fibonacci(N);


void Fibonacci (int N)
{
int i=0;
int first=0;
 System.Console.Write($"{first,6}");
int second=1;
int sum=0;
while (i<(N-1))
{
    sum=first+second;
    System.Console.Write($"{sum,6}");
    first=second;
    second=sum;
    i++;
}
}

