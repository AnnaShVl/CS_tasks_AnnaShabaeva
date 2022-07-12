// Дано число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a,b,c;
string? s;
s=Console.ReadLine();//просит ввести число
a=Convert.ToInt32(s);//преобразует формат числа в int
b=a/10;
c=a%10;

if (c>b)
{ 
    System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine(b);
}