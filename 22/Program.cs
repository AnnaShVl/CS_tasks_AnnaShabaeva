// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число");
int num=Convert.ToInt32(Console.ReadLine());

int a,b,c,d;
a=num%10;
b=(num%100)/10;
c=(num%10000)/1000;
d=num/10000;

if (a==d && b==c)
{
    Console.WriteLine("Число - палиндром");
}
else
{
    Console.WriteLine("Число - не палиндром");
}

//Console.WriteLine($"{a} {b} {c} {d}");