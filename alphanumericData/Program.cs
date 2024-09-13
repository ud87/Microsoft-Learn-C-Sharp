/*
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);    //{1} stands for second variable
Console.WriteLine("{0} {0} {0}!", first, second);    //{0} stands for first variable


//string interpolation is a technique that simplifies composite formatting
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");    
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


//Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");  //:C formats the number as currency regardless of whether you use int or decimal


//Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");  //N by default shows two digits after the decimal point
Console.WriteLine($"Measurement: {measurement:N4} units");  //N4 shows 4 digits after the decimal point


//Formatting %
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");      //p2 means percentage and show 2 digits after the decimal point

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);



//Explore string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"  Shares: {productShares:N3} Product");
Console.WriteLine($"   Sub Total: {subtotal:C}");
Console.WriteLine($"    Tax: {taxPercentage:P2}");
Console.WriteLine($"      Total Billed: {total:C}");


//Formatting strings by adding whitespace before or after - PadLeft() method adds blank spaces to the LHS of the string
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));  //adjusts input to the left so total string becomes 12
Console.WriteLine(input.PadRight(12));   //adjusts imput to the right so total string becomes 12


Console.WriteLine(input.PadLeft(12, '*'));
Console.WriteLine(input.PadRight(12, '*'));


//Add the Payment ID to the output
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "£300000";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/


//Excercise - complete a challenge to apply string interpolation to form letter

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($@"Dear {customerName},
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N2} at a return of {currentReturn:P2}.

Our new product, Glorious Future offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.
");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = $@"Magic Yield         {currentReturn:P2}      {currentProfit:C}
Glorious Future     {newReturn:P2}      {newProfit:C}";
Console.WriteLine(comparisonMessage);












