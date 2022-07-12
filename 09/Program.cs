//Вывести на экран четные числа от 1 до N

int i=0;
int N;
string? s;
s=Console.ReadLine();//просит ввести число
N=Convert.ToInt32(s);//преобразует формат числа в int
while (i<=N)
{
    System.Console.Write($"{i}  ");
    i=i+2;
}
