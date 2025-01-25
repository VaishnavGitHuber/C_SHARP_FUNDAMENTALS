### This repository conatain C# Learning materials in ordered way.
This repository provides a concise guide to C# programming, covering fundamental concepts with examples. Each concept is explained with well-commented code for ease of understanding.

## Table of Contents
1. [Variable Declaration and Initialization](#1-variables-in-c)
2. [Datatypes in C#](#2-datatypes-in-c)
3. [Working With Strings](#3-working-with-strings)
4. [Working with Numbers](#4-working-with-numbers)
5. [Getting input from user](#5-Getting-input-from-user)
6. [TASK1: Building a Sinmple Calculator](#6-Building-a-simple-calculator)
7. [TASK2: Building a MindLibGame](#7-Building-a-MindLibGame)
8. [Functions in c#](#8-Functions-in-CSHARP)
9. [Condition Statments in c#](#9-Condition-statements-in-csharp)
10. [Iteration Statments in C Sharp](#10-Iteration-Statments-in-C-Sharp)

## 1. Variables in C#
Variables in c# must be declared with a specific data type before use. Here's an example:
```
1. Variables: Containers for storing the data
    // Syntax: datatype identifier;

// Variable declaration and initialisation
        string name; // declaration
        name = "Vaishnav Krishna P"; // initialisation
        int age = 18; // declaration and initialisation
```

## 2. Datatypes in C#
```
2. Data types: It tells the types of the data that can be stored in the PL
    2.1 String : to store collection of charectors 
    2.2 Char: to store a single charector
    2.3 int : to store a numerical value without decimal points 
    2.4 Float/Double/decimal : store the numerical values with decimal points 
    2.5 bool : store boolean data ie, true or false 

    // Data types in c# 
        string name = "Vaishnav Krishna P";
        char gender = 'M';
        int age = 24;
        float num1 = 23.45F;
        double num2 = 34.5555;
        decimal num3 = 43.2222211M;
        bool is_vaild = true;
```

## 3. Working with Strings
```
3. Working with strings 
    3.1 .Length : to get the number of charectors in the string 
    3.2 .ToUpper() : to convert all the cahrectors to upper case
    3.3 .ToLower() : to convert all the charectors to lower case 
    3.4 .Contains(string) : to check whether a specific part of 
    string is present in programme or not, return bool
    3.5 .IndexOf(string) : return the index number of 
    first occurence of first charector in string 
    3.6 .substring(start_index, no_of_charectors) : to return the
     substring of the string

     // Working with the strings 
    string text = "This Is Amazing";

    Console.WriteLine(text.Length); // return the number of char in str
    Console.WriteLine(text.ToUpper()); // convert to upper case
    Console.WriteLine(text.ToLower()); // convert to lower case 
    Console.WriteLine(text.Contains("Amazing")); // return bool  
    Console.WriteLine(text.IndexOf("Amazing")); // return index position
    Console.WriteLine(text.Substring(8, 5)); // return substring
```
## 4. Working with Numbers
```
4. Working with numbers 
    int * int -> int, int * float -> float, float * float -> float
    Assume * is a operator
    4.1 Math.Abs(number)
    4.2 Math.Pow(number, power_of)
    4.3 Math.sqrt(number)
    4.4 Math.Max(num1, num2, num3)
    4.5 Math.Min(num1, num2, num3)
    4.6 Math.Round(number)

    Console.WriteLine(Math.Abs(-28));
    Console.WriteLine(Math.Sqrt(25));
    Console.WriteLine(Math.Pow(2, 8));
    Console.WriteLine(Math.Max(34, 56));
    Console.WriteLine(Math.Min(34, 78));
    Console.WriteLine(Math.Round(21.76));

```
## 5. Getting input from user
```
5. Getting input from the user 
    5.1 Console.ReadLine() <- return input as string, doesnot have parameter 
    5.2 Console.Read() <- return input as integer of ascii 

    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    Console.Write("Enter your age: ");
    age = Console.ReadLine();
    Console.WriteLine("Your name is: " + name + " you are " + age);
```
## 6. Building a simple calculator
```
double num1, num2, result;
        Console.Write("Enter the first Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        result = num1 + num2;

        Console.WriteLine("Result is: " + Math.Round(result));
```
## 7. Building a MindLibGame
```
        string color, pleural_noun, celebraty;

        Console.Write("Enter your color: ");
        color = Console.ReadLine();
        Console.Write("Enter your pleural_noun: ");
        pleural_noun = Console.ReadLine();
        Console.Write("Enter your celebraty: ");
        celebraty = Console.ReadLine();

        Console.WriteLine("Roses are " + color);
        Console.WriteLine(pleural_noun + " are blue");
        Console.WriteLine("I Love " + celebraty);
```

## 8. Functions in CSHARP
```
Functions in C# : block of code that can be reused again and again 
    8.1 Function with parameter and with return value 
    8.2 Function with parameter and without return value 
    8.3 Function without parameter and with return value 
    8.4 Function without parameter and without return value 

    syntax: 
    static return_type function_name(data_type parameter1,...)
    {
        // block of code
    }
```
## 9 Condition statements in csharp
```
9.1 Simple If block
    9.2 If-Else block
    9.3 Else-If Ladder block
    9.4 Switch Statement 

    syntax for if-else:
    if(condition)
    {
        // if block
    }
    else if(condition)
    {
        // else if block
    }
    else 
    {
        // else block
    }

    syntax for switch 
    switch(choice_variable)
    {
        case 1:
            // case1 block 
        case 2:
            // case2 block 
        .
        .
        default: 
            // default block 
    }
```
## 10. Iteration Statments in C Sharp
```
10.1 While Loop
    10.2 Do-While Loop
    10.3 ForLoop

    syntax for while loop: Iteration is continued untill the condition is true
    while(condition) 
    {
        // block of code
    }

    syntax for do-while loop: Iteration is continued untill the condition is true
    do
    {
        // block of code
    }while(condition) 

    syntax for forloop: Iteration is continued untill the condition is true
    for(initialisation; condition; increment/decrement)
    {
        // block of code 
    }
```