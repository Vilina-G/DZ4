
using System;

public class Homework_04
{
    public static void Main()
    {
        z25();
        z27();
        z29();
    }

     static void z29()
     {
        System.Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
        var num = new[] { 0 , 1 , 2 , 3 , 4 , 5 , 6 , 7 };
        var counter = 0;
        while (num.Length > counter)
            {
                System.Console.Write(num[counter]);
                counter++;
            }
     }


    static void z27()
    {
        System.Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        int num = getNumber();
        summ(num);
    }
    static void summ(int c)
    {
       var number = c;
       var summa = 0;
            while (number > 0)
            {
                summa = summa + (number % 10);
                number = number / 10;
            }
     System.Console.WriteLine(summa);
    }



    static void z25()
    {
        System.Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
     int num = getNumber();
     int num1 = getNumber();
    degree(num , num1);

    }
    static void degree(int a,int b)
    {
     System.Console.WriteLine( Math.Pow(a,b));
    }
    static int getNumber()
    {
        System.Console.WriteLine($"Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

}


