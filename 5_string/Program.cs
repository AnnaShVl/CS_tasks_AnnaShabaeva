// Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
//Вычислить сумму цифр введенного числа




using System;
                    
public class Program
{
    public static void Main() {
        string number = Console.ReadLine();
        int sum = 0;
        for (int i = 0; i < number.Length; i++) {
            if (char.IsDigit(number[i])) {
                sum += number[i] - 48;
            }
            else {
                // пропуск минуса в начале, если он есть
                if (i == 0 && number[i] == '-') {
                    continue;
                }
                else {
                    Console.WriteLine("Это не является верной записью целого");
                    return;
                }
            }
        }
        Console.WriteLine("Сумма цифр числа: {0}", sum);
    }
}






/*string s=Console.ReadLine();
int sum=0;
for (int i=0;i<s.Length;i++)
    if (char.IsDigit(s[i]))
        sum=sum+(int)(char.GetNumericValue(s[i]));
    else 
        System.Console.WriteLine("Введено не целое число");
        return;
System.Console.WriteLine(sum);*/