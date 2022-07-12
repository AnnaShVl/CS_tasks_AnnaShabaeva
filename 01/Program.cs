// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*int a=2, b=3;
int s=a+b;
System.Console.WriteLine(a+"+"+b+"="+s);
System.Console.WriteLine("{0}+{1}={2}", a,b,s);
System.Console.WriteLine($"{a}+{b}={s}");*/

//С клавиатуры вводится целое число. Вывести квадрат числа 
int a;
int b;
string? s;
s=Console.ReadLine();//просит ввести число
a=Convert.ToInt32(s);//преобразует формат числа в int
b=a*a;
System.Console.WriteLine($"{a}*{a}={b}");

/*для дробных чисел
double a, b;
string? s;
s=Console.ReadLine();//просит ввести число
a=Convert.ToDouble(s);//преобразует формат числа в int
b=a*a;
System.Console.WriteLine($"{a}*{a}={b}");*/


