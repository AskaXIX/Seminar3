// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите 5 значное число: ");
string? str = System.Console.ReadLine();

if (str!.Length == 5 && str![0] == str![4] && str![1] == str![3] && str![2] != str![0] && str![2] != str![1])
{
    System.Console.WriteLine($"{str} - correct!");
}
else
{
    System.Console.WriteLine($"{str} - incorrect!");
}