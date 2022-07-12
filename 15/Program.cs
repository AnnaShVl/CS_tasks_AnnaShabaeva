// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

int a,b,c;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a%1000;
c=b/100;

if (c>0)
{
    System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}