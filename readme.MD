### This repository conatain C# Learning materials in ordered way.
This repository provides a concise guide to C# programming, covering fundamental concepts with examples. Each concept is explained with well-commented code for ease of understanding.

## Table of Contents
1. [Variable Declaration and Initialization](# 1.-Variables-in-C#)
2. [Datatypes in c#](# 2.-Datatypes-in-c#)
3. [Working With Strings](# 3.-working-with-strings)
4. [Working with Numbers](# 4.-working-with-numbers)

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

## 2. Datatypes in c#
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

## 3. Working With Strings
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
## 4. Working With Numbers
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
