### This repository conatain C# Learning materials in ordered way.
This repository provides a concise guide to C# programming, covering fundamental concepts with examples. Each concept is explained with well-commented code for ease of understanding.
### Thankyou so much Giraffe accademy and MadTargerson for helping me to learn basics of C#

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
11. [Task3: Better Calculator](#11-Building-better-calculator)
12. [Task4: Cube Function](#12-Cube-Function)
13. [Task5; Maximum of 3 Numbers](#13-Get-maximum-of3)
14. [Arrays in C #](#14-Arrays-in-Csharp)
15. [Word Guess Game](#15-word-guess-game)
16. [2D Array](#16-2D-Array-in-CSharp)
17. [Exception Handling](#17-Exception-Handling)
18. [Class,Objects,Constructor in C#](#18-Class-Objects-Constructor-in-CS)
19. [Static class, Method, attribute](#19-static-class-object-method)
20. [Getter and Setter](#20-Getter-and-Setter)
21. [Inheritance in C Sharp](#21-Inheritance-in-CSharp)

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
## 11. Building better calculator
```
        double num1, num2, result = 0;
        string oper;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a operator: ");
        oper = Console.ReadLine();
        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (oper == "+")
        {
            result = num1 + num2;
        }
        else if (oper == "-")
        {
            result = num1 - num2;
        }
        else if (oper == "*")
        {
            result = num1 * num2;
        }
        else if (oper == "/")
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Enter a valid operator");
        }

        Console.WriteLine("Result is: " + result);
```
## 12. Cube Function
```
    static void Main(string[] args)
    {
        int Num = 5, CubeValue;
        // cube function 
        CubeValue = GetCube(Num); // function call
        Console.WriteLine("Cube of " + Num + " is " + CubeValue);

    }

    // function declaration
    static int GetCube(int number)
    {
        int output;
        output = number * number * number;
        return output; // return statment
    }
```
## 13. Get maximum of3
```
    static void Main(string[] args)
    {
        int num1 = 23, num2 = 67, num3 = 75, greatestNumber;
        greatestNumber = num1;

        greatestNumber = GetMaxOf3(num1, num2, num3);
        Console.WriteLine("Greatest number: " + greatestNumber);
    }

    static int GetMaxOf3(int num1, int num2, int num3)
    {
        int greatest = num1;

        if (num1 > num2 && num1 > num3)
        {
            greatest = num1;
        }
        else if (num2 > num3 && num2 > num1)
        {
            greatest = num2;
        }
        else if (num3 > num1 && num3 > num2)
        {
            greatest = num3;
        }

        return greatest;
    }
```
## 14. Arrays in Csharp
```
14. Arrays in C# : Used to stored multiple values 
    14.1 declaration of Arrays 
    datatype[] array_name = {value1, value2, value3, ...};
    or 
    datatype array_name = new datatype[size];
    array_name[index] = value;

        int[] numbers = { 3, 4, 5, 6 };
        string[] colors = new string[4];
        colors[0] = "red";
        colors[1] = "pink";
        colors[2] = "blue";
        colors[3] = "violet";

```
## 15. word guess game
```
        string guessedWord = "", secretWord = "Apple";
        int limit = 3, chance = 0;
        bool isCorrect = false;

        while (guessedWord != secretWord && chance < limit)
        {
            Console.Write("Enter your guess" + (limit - chance) + " chance left: ");
            guessedWord = Console.ReadLine();
            chance += 1;
            if (secretWord == guessedWord)
            {
                isCorrect = true;
            }
        }
        if (isCorrect)
        {
            Console.WriteLine("You Won");
        }
        else
        {
            Console.WriteLine("You Loss");
        }
```
## 16. 2D Array in CSharp
```
16. 2D Array
syntax: 
datatype[,] array_name = { {value1, value2, .... }, {value1,... }, {value1,...}, ...} OR
datatype[,] array_name = new datatype[n,m]

        int[,] array = {
            {2, 3},
            {4, 5},
            {6, 7}
        };
        string[,] colors = new string[2, 3];
        colors[0, 0] = "red";
        colors[0, 1] = "blue";
        colors[1, 0] = "pink";
        colors[1, 1] = "Rose";

        // Accssing the elements in the 2D Array
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(colors[i, j]);
            }
        }
```
## 17. Exception Handling
```
17. Exception Handling in c-sharp : Using C# 
    17.1 Exception : to handle any kind of exception
    17.2 DivideByZeroDivision : to handle the divide by zero exception
    17.3 FormatException : to handle the format exception 

    try
        {
            Console.Write("Enter number1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 / num2;
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Excecution completed Sucessfully...");
        }
    
```
## 18. Class Objects Constructor in CS
```
class : template for creating objects
objects: instance of class 
constructor: special method exceuted when a class is initiated
syntax 
class class_name { // attributes, method, constructor }

class HelloWorld
{
    static void Main(string[] args)
    {
        Book book1 = new Book("JK Rowlings", "HarryPorter", 340);
        book1.DisplayInfo();
    }
}

public class Book
{
    public string author, title;
    public int noOfPages;

    // constuctor
    public Book(string aAuthor, string aTitle, int aNoOfPages)
    {
        author = aAuthor;
        title = aTitle;
        noOfPages = aNoOfPages;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + title + " Author: " + author + " No of pages: " + noOfPages);
    }
}
```
## 19. static class object method
```
static attribute : attribute shared by all the intances of class 
syntax
static attribute_name 

static method: method that can be called which out created objects 
syntax:
static method_name(arg1, arg2, ...){ ... }

static class: class that cannot be initiated, such classes cannot create objects
static class class_name { ... }

class HelloWorld
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Swift", "MaruthiSusuki", 4, 20.5F);
        Car car2 = new Car("A-Class", "Benz", 5, 10.5F);
        Console.WriteLine(Car.GetObjectsCount());
    }
}


class Car
{
    public string name, model;
    public float mileage;
    public int rating;
    public static int noOfObjects = 0;

    public Car(string aName, string aModel, int aRating, float aMileage)
    {
        name = aName;
        model = aModel;
        rating = aRating;
        mileage = aMileage;
        noOfObjects += 1;
    }

    public static int GetObjectsCount()
    {
        return noOfObjects;
    }

}
```
## 20. Getter and Setter
```
20. Getters and setters : used to get and set the prvate attributes 
which are not accessable outside the class
syntax:
public datatype attributeName 
{ 
get { return attributename }
set { attributeName = value }
}


class HelloWorld
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator("CASIO");
        calculator.BrandName = "MIKE JIO";
        Console.WriteLine(calculator.BrandName);
    }
}

class Calculator
{
    private string brandName;
    public Calculator(string aBrandName)
    {
        brandName = aBrandName;
    }

    public string BrandName
    {
        set
        {
            brandName = value;
        }
        get
        {
            return brandName;
        }
    }

}
```
## 21 Inheritance in CSharp
```
21. Inheritance: creating a class from the existing class 
syntax: 
newClassname : existingClassName { // attribute,method,constructor }

class HelloWorld
{
    static void Main(string[] args)
    {
        NewHuman human = new NewHuman();
        Human Oldman = new Human();
        Oldman.GetProperties();
        human.GetProperties();
    }
}

class Human
{
    public int noOfLeg = 2, noHands = 2;
    public bool canSpeak = true;

    public virtual void GetProperties()
    {
        Console.WriteLine("Human can speak, eat, and walk");
    }
}

class NewHuman : Human
{
    public bool canWalk = true;
    public override void GetProperties()
    {
        Console.WriteLine("Human can speak, eat, walk, dance and, sing");
    }
}
```
