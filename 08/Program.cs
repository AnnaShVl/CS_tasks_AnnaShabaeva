// Вывести на экран числа от -N до N

int N;
string? s;
s=Console.ReadLine();//просит ввести число
N=Convert.ToInt32(s);//преобразует формат числа в int

int i=-N;
while (i<=N)
{
    System.Console.Write($"{i}  ");
    i=i+1;}
