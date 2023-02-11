// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// public static TSelf Cbrt (TSelf x);

Console.Clear();
Console.WriteLine("Введите число");
int cube = int.Parse(Console.ReadLine()!);

int count = 1;

while (count <= cube)
{
   Console.Write(count * count * count);
   
   if (count != cube) Console.Write(", ");
   count++;
}