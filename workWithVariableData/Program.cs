/*

Data types can be of two types

1) value types (value type variable stores its values directly in an area of storage called the stack which is a memory allocated to the code that is currently running on the CPU when the stack frame has finished executing the values in the stack are removed)
    Integral type is a simple value type that represents whole numbers with no fractions for e.g. 1, 0, 2, -1. Most popular type is int
    There are two sub categories of integral types. 
    Signed type - uses    its bytes to represent an equal no of positive and negative nos.
    Unsigned type - uses its bytes to represent only positive numbers

    Floating point type is a simple value type that represents numbers to the right of the decimal place
    float and double values are stored internally in a binary base 2 format. Large no can be stored using a small memory footprint however only use when approximation is useful
    decimal is stored in a decimal base 10 format. use this when we need precise answer. Has large memory footprint.


2) reference types (stores its values in a seperate memory called the heap which is an area that is shared across many applications running on the OS at the same time. 
    .NET Runtime communicates with the OS to determine what memory addresses are available and requests an address whre it can store the value. .NET runtime stores the value 
    and returns the memory address to the variable)

    int[] data = new int[3]
    string shortenedString = "Hello World!"

Choose the correct data types when in doubt stick with the basics
- int for most whole nos
- decimal for numbers representing money
- bool for true or false values
- string for alphanumeric values

*/


//Excercise for signed type
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int   : {int.MinValue} to {int.MaxValue}"); 
Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");
//for most of the time we wont need more than a +ve to -ve 2.14 billion nos i.e. int


//Excercise for unsigned type
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


//Excercise for signed float type
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


