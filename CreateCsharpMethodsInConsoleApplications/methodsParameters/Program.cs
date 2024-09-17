/*

//passing parameters to methods allows us to perform the task with different input values. We can provide same method and just change parameters

CountTo(5);

void CountTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.Write($"{i}, ");
    }
}


//create a method with parameters

int[] schedule = { 800, 1200, 1600, 2000, };
DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) //decalre params similar to variables
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        Console.WriteLine("Invalid GMT");
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}


//Ex - Understand method scope
//scope is the region of a program where certain data is accessible. variables declared inside a method or any scope is only accessible within that scope

string[] student = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(student);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)   //pass array students as paramters
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}



//Ex - print circle area
double pi = 3.14159;
PrintCircleInfo(34);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}




//value types such as int, bool, float, double and char directly contains values. Reference types such as string, array dont store their values directly. instead stores an address where their value is stored
//passing reference

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");  //outside of method c retains original value of 0

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");   //inside method c value is changed
}



//Test pass by reference
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a}");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}



//Test with strings
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}


//Methods with optional params

string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);  //named argument must be used in position, name argument is an element of array and mist be positionally correct
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
    if (inviteOnly)  //true or false
    {
        //search guestList before adding rsvp
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

//Recap
    //Parameters are made optional by setting a default value in the method signature.
    //Named arguments are specified with the parameter name, followed by a colon and the argument value.
    //When combining named and positional arguments, you must use the correct order of parameters.


*/



//Excercise - complete the challenge to display email addresses
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};
string internalDomain = "contoso.com";
string prefix = "";
string[] internalEmails = new string[corporate.GetLength(0)];  // Length of the corporate array

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string[] externalEmails = new string[external.GetLength(0)];


// Calling methods
GetInternalEmails();
GetExternalEmails();


void GetInternalEmails()
{
    for (int i = 0; i < corporate.GetLength(0); i++)     // Loop through rows
    {
        prefix = "";  // Reset prefix each time

        for (int j = 0; j < corporate.GetLength(1); j++)   // Loop through columns
        {
            if (j % 2 == 0)   // First name
            {
                prefix = corporate[i, j].Substring(0, 2).ToLower();  // Get first 2 characters of first name
            }
            else              // Last name
            {
                prefix += corporate[i, j].ToLower();  // Add last name to the prefix
            }
        }

        // Construct email and store in internalEmails array
        internalEmails[i] = $"{prefix}@{internalDomain}";
    }

    // Print internal emails after processing
    foreach (string email in internalEmails)
    {
        Console.WriteLine(email);
    }
}


void GetExternalEmails()
{
    for (int i = 0; i < external.GetLength(0); i++)     // Loop through rows
    {
        prefix = "";  // Reset prefix each time

        for (int j = 0; j < external.GetLength(1); j++)   // Loop through columns
        {
            if (j % 2 == 0)   // First name
            {
                prefix = external[i, j].Substring(0, 2).ToLower();  // Get first 2 characters of first name
            }
            else              // Last name
            {
                prefix += external[i, j].ToLower();  // Add last name to the prefix
            }
        }

        // Construct email and store in externalEmails array
        externalEmails[i] = $"{prefix}@{externalDomain}";
    }

    // Print external emails after processing
    foreach (string email in externalEmails)
    {
        Console.WriteLine(email);
    }
}
