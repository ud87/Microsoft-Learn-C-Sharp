/*purpose of code blocks is to control or limit variable accessibility, scope, group of lines that should be executed
boundaries of code block is defined by {}
locally scoped variable is only accessible inside code block, global scoped can be accessed anywhere
variables must always be initialized and assigned a value before using it

//*****************************************************************************
bool flag = true;
int value = 0;
if (flag)
{
    
    Console.WriteLine($"Inside the code block: {value}");

}

value = 10;
Console.WriteLine($"Outside the code block: {value}");


//******************************************************************************
int val1 = 5;
if (val1 > 0)
{
    int val2 = 6;
    val1 += val2;
}
Console.WriteLine(val1);
*/



//*****************Excercise Remove code blocks from if statements**************
    //****Example 1 If codeblock only requires one line of code we can remove the code blocks
    bool flag = true;
    if (flag)
        Console.WriteLine(flag);

    //********Example 2*******************
    string name = "steve";

    if (name == "bob")
        Console.WriteLine($"Found {name}");
    else if (name == "steve")
        Console.WriteLine($"Found {name}");
    else
        Console.WriteLine($"Found {name}");


    //********challenge activity using variable scope**********
    int [] numbers = {4, 8, 15, 16, 23, 42};
    int total = 0;          //initialize global variable and assign value of 0
    bool found = false;     //initialize global variable and assign value of false

    foreach (int number in numbers)
    {
        total += number;

        if (number == 42)
        {
            found = true;
        }
    }

    if (found)
    {
        Console.WriteLine("Set contains 42");
    }
    Console.WriteLine($"Total: {total}");