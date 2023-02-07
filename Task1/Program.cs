// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();
int length = number!.Length;

if ( length == 5 )
{
    if (number[1] == number[3] && number[0] == number [4])
        {
            System.Console.WriteLine("Число является палиндромом");
        }
    else
        {
        System.Console.WriteLine("Число не является палиндромом");
        }
}
else System.Console.WriteLine("Число не пятизначное");