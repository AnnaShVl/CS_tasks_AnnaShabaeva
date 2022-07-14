// Найти сумму чисел от 1 до А

Console.WriteLine("Введите целое число");
int A=Convert.ToInt32 (Console.ReadLine());

int n, s;
n=1;
s=0;

while (n<=A)
{
    s=s+n;
    n++;
}

Console.Write(s);