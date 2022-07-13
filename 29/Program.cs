// 29. Подсчитать сумму цифр в числе

Console.WriteLine("Введите целое число");
int num=Convert.ToInt32(Console.ReadLine());

int sum, div, a;
sum=0;
div=1;
a=1;

while (a!=0)
{
    a=(num%(div*10))/div;
    sum=sum+a;
    div=div*10;
}
 Console.WriteLine(sum);


