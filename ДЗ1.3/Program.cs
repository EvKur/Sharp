﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 ==0){
    Console.WriteLine($"Введенное число - четное");   
}
else
{
    Console.WriteLine($"Введенное число - нечетное");   
}
//