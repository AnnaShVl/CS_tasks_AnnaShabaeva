// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a;
string? s;
s=Console.ReadLine();//просит ввести число
a=Convert.ToInt32(s);

System.Console.WriteLine($"{a%10}");
