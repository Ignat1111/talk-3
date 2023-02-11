﻿// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите Пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 10000 || num > 100000)
   Console.WriteLine($"Это число не пятизначное.Повторите попытку!!");
else
{
   int b = num / 1000, e = num % 100;
   if ((b / 10 == e % 10) && (b % 10 % 10 == e / 10))
      Console.WriteLine("Да, оно является палиндромом");
   else
      Console.WriteLine("Нет. оно неявляется палиндромом");
}