// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
String number = Console.ReadLine();
int n = Convert.ToInt32(number);
int i = Convert.ToInt32(Math.Pow(10,number.Length - 1));
int NextNumber = 0;
int sum = 0;

for (int count = 1; count <= number.Length;  count ++)
{
    NextNumber = n / i % 10;
    sum = sum + NextNumber; 
    i = i/10; 
}
Console.Write(sum);
