﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Please add a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 % 2 == 0) 
  Console.WriteLine("yes");
else 
  Console.WriteLine("No");
