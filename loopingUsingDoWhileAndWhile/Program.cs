/*
Do while and while statements allows us to control the flow of code execution by looping through a block of code until a condition is met
for e.g. accepting user input from user in correct format
*/


//Syntax of Do while
/*
do
{
    // This code executes at least one time
} while (true);

key notes:
1) Do while will execute at least once
2) A code block that influences the exit criteria is a primary reason to select a do while or while statements
*/

/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);



while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/


//*******Challenge Role playing game battle challenge**************
/*
You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

/*
int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();
int attack = random.Next(1, 11);

do
{
    Console.WriteLine("Hero attacks !!!");
    attack = random.Next(1, 11);
    monsterHealth -= attack;
    Console.WriteLine($"Remaining Monster Health: {monsterHealth}");
    if (monsterHealth > 0)
    {
        attack = random.Next(1, 11);
        heroHealth -= attack;
        Console.WriteLine($"Monster attacks\nRemaining hero health: {heroHealth}");
        if (heroHealth <= 0)
        {
            Console.WriteLine("Monsterwins");
            return;
        }
    }
    else if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins !!!!");
        return;
    }
    
    
} while (heroHealth > 0 || monsterHealth > 0);*/



//*************Challenge activity to differentiate between do and while iteration statement***********
//do while runs one or more times, while statement runs zero or more times

//***************Challenge 1: Write code that validates integer input*******************************
//url: https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
/*
string readResult;
int number = 0;
bool validNumber = true;
Console.WriteLine("Enter an integer value between 5 and 10");
do {
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out number);
    if (!validNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    else if (number >= 5 && number <= 10)
    {
        continue;
    }
    else Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
}while (number < 5 || number > 10);
Console.WriteLine($"Your input value({number}) has been accepted.");
*/


//------------------Challenge 2: Write code that valudates string input---------------------------------------------------------
//url: https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
/*
string role = "";
bool notMatch = true;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
while (notMatch)
{
    role = Console.ReadLine().Trim().ToLower();
    if (role == "administrator" || role == "manager" || role == "user")
    {   
        notMatch = false;       //exits the loop
    }
    else Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
}
Console.WriteLine($"Your input value ({role}) has been accepted.");
*/



//-------------------Challenge 3: Write code that processes the contents of a string array-------------------------------------
//url: https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
foreach (string str in myStrings)
{
    string myString = str;
    
    while (myString.IndexOf(".") != -1)
    {
        periodLocation = myString.IndexOf(".");         //finds the index of .
        Console.WriteLine(myString.Substring(0, periodLocation).TrimStart());   //creates a new string from index zero to index . trimstart removes all spaces

        //update mystring which removes all the previous characters before . and + 1 includes the .
        myString = myString.Substring(periodLocation + 1);        
    };

    Console.WriteLine(myString.TrimStart());    //prints the remaining characters   
}

