﻿using System;


public delegate void MyDelegate(string message);


class Program
{
    static void Main()
    {
        MyDelegate myDelegate = Method1;
        myDelegate += Method2;


        myDelegate("Hello, world!");


        myDelegate -= Method1;
        myDelegate("Another message.");
        Console.ReadKey();  
    }


    static void Method1(string message)
    {
        Console.WriteLine("Method1: " + message);
    }


    static void Method2(string message)
    {
        Console.WriteLine("Method2: " + message);
    }
}