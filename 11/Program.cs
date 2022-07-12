//Дано число больше 9. Вывести на экран  вторую цифру числа с конца


int a,b,c;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a/10;
c=b%10;

System.Console.WriteLine(c);
