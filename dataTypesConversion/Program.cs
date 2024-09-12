/*
//Question 1 : Is it possible that attempting to change the values data type would throw an exception at run time?

//Write code that attempts to add an int and a string and save the result in int - C# directly does not convert string to int but converts int to string

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

//Question 2: Is it possible that attempting to change the values data type would result in a loss of information ?

int myInt = 3;
Console.WriteLine($"int: {myInt}");;

decimal myDecimal = myInt;;
Console.WriteLine($"decimal: {myDecimal}"); //since any int value can easily fit inside a decimal, compiler performs the conversion



Narrowing conversion - means that you are converting a data type that can hold more information to the data type that can hold less information e.g. decimal to int conversion
    when we know that we are performing a narrower conversion then we need to perform cast. Cast is an instruction to C# complier informing precision may lost but we are willing to accept it

    narrowing conversion example below
    ----------------------------------
    decimal myDecimal = 1.23456789m;
    float myFloat = (float)myDecimal;

    Console.WriteLine($"Decimal: {myDecimal}");
    Console.WriteLine($"Float: {myFloat}");



Widening conversion - is the opposite of Narrowing conversion.


decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");
int myInt = (int)myDecimal;  //Here (int) is the casting operation that could lose 0.14m, but we are telling the compiler that we are performing an intentional conversion, an explicit conversion
Console.WriteLine($"int: {myInt}");


Performing Data conversions
-----------------------------
- Use a helper method on the variable
- Use a helper method on the data type
- Use the Convert class methods

//Use ToString() to convert a number to a string - on most occasions it performs a widening conversion.
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);


//Convert a string to an int using the Parse() helper method. Use TryParse() method whenever possible
string fifth = "5";
string seventh = "7";
int sum = int.Parse(fifth) + int.Parse(seventh);  //use TryParse() which is a better version of the Parse() method
Console.WriteLine(sum);


//Convert a string to an  int using the Convert class. Convert class has many helper methods to convert a value from one type to another
//Best use case of this method is to convert fractional numbners into whole numbers 
string value1 = "5";
string value2 = "6";
int result = Convert.ToInt32(value1) + Convert.ToInt32(value2); //System.Int32 is the name of the underlying data type in the .NET class library
Console.WriteLine(result);


//Compare cast6ing and converting a decimal into an int
int value = (int)1.5m; //casting truncates
Console.WriteLine(value);   //just truncates and does not round up

int values = Convert.ToInt32(1.5m); //Converting rounds up
Console.WriteLine(values);  //rounds up



//Excercise - Examine the TryParse() method 

string name = "Bob";
Console.WriteLine(int.Parse(name));    //returns System.FormatException: 'Input string was not in a correct format.'

//In this instance we need to use TryParse() it attempts to parse a string to number, if sucessful it sotes the converted value in out parameter, if not then it returns a bool to indicate whether the action succeeded or failed
string value = "102";
int result = 0;
if (int.TryParse(value, out result))  //out holds the value if string can be sucessfully converted to a number
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}"); //to demonstrate the TryParse assigned result can be used if TryParse is successful


//Modify the string variable to a vlaue that can't be parsed
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))  //if sucessfully convert string to number returns true and assigns value to result)
{
   Console.WriteLine($"Measurement: {result}");     
}
else
{
   Console.WriteLine("Unable to report the measurement.");     //in this scenario it is false because bad cannot be converted to number 
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");   //we need to add this condition because result is 0, no point showing default value 0  if measurement cannot be taken 


//Key points - use TryParse() when converting str to number, returns true if successful and false if unsuccessful, out parameter stores the value if true



//Challenge 1

using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = {"12.3", "45", "ABC", "11", "DEF"};
string message = "";
decimal subTotal = 0;
decimal total = 0; 

foreach (string value in values)
{
    if (decimal.TryParse(value, out subTotal))
    {
        total += subTotal;
    }
    else 
    {
        message += value;
    }
}

if (message.Length > 0)
{
    Console.WriteLine($"Message: {message}");
}

if (total > 0)
{
    Console.WriteLine($"Total: {total}");
}

*/



//Challenge 2

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


