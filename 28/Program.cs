// Определить количество цифр в числе. Сделать подпрограмму.

Console.WriteLine("Введите целое число");
int A=Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine(CountDigits(A));

int CountDigits(int N)//8-18 строки-подпрограмма
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N/=10;        
    }
    return k;
}