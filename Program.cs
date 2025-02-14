﻿// See https://aka.ms/new-console-template for more information
/*
1. Variables: Containers for storing the data
    // Syntax: datatype identifier;

2. Data types: It tells the types of the data that can be stored in the PL
    2.1 String : to store collection of charectors 
    2.2 Char: to store a single charector
    2.3 int : to store a numerical value without decimal points 
    2.4 Float/Double/decimal : store the numerical values with decimal points 
    2.5 bool : store boolean data ie, true or false 

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

4. Working with numbers 
    int * int -> int, int * float -> float, float * float -> float
    Assume * is a operator
    4.1 Math.Abs(number)
    4.2 Math.Pow(number, power_of)
    4.3 Math.sqrt(number)
    4.4 Math.Max(num1, num2, num3)
    4.5 Math.Min(num1, num2, num3)
    4.6 Math.Round(number)

5. Getting input from the user 
    5.1 Console.ReadLine() <- return input as string 
    5.2 Console.Read() <- return input as integer of ascii 

6. Building a Simple Calculator 

7. Building a MindLib Game 

8. Functions in C# : block of code that can be reused again and again 
    8.1 Function with parameter and with return value 
    8.2 Function with parameter and without return value 
    8.3 Function without parameter and with return value 
    8.4 Function without parameter and without return value 
    syntax: 
    static return_type function_name(data_type parameter1,...)
    {
        // block of code
    }

9. Condition Statments 
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
10. Iteration Statments in C Sharp 
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
11. Building Better Calculator
12. Cube Function 
13. Get Maximum of 3 numbers
14. Arrays in C# : Used to stored multiple values 
    14.1 declaration of Arrays 
    datatype[] array_name = {value1, value2, value3, ...};
    or 
    datatype array_name = new datatype[size];
    array_name[index] = value;
15. Building a Guess Game using C# 
16. 2D Array
syntax: 
datatype[,] array_name = { {value1, value2, .... }, {value1,... }, {value1,...}, ...} OR
datatype[,] array_name = new datatype[n,m]
17. Exception Handling in c-sharp : Using C# 
    17.1 Exception : to handle any kind of exception
    17.2 DivideByZeroDivision : to handle the divide by zero exception
    17.3 FormatException : to handle the format exception
18. Class,Objects,Constructor in C#
19. static class, method, attribute 
static attribute : attribute shared by all the intances of class 
syntax
static attribute_name 

static method: method that can be called which out created objects 
syntax:
static method_name(arg1, arg2, ...){ ... }

static class: class that cannot be initiated, such classes cannot create objects
static class class_name { ... }
20. Getters and setters : used to get and set the prvate attributes 
which are not accessable outside the class
syntax:
public datatype attributeName 
{ 
get { return attributename }
set { attributeName = value }
}
21. Inheritance: creating a class from the existing class 
syntax: 
newClassname : existingClassName { // attribute,method,constructor }
*/
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