/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');    //returns the index of arg
int closingPosition = message.IndexOf(")");

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));  //gets the string in between opening position and 


string message = "what is the value <span>between the tags</span>?";

const string openSpan = "<span>";   //to avoid using hard coded values directly in the code
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += 6;    //skips <span>
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));




//Ex1 use the string's IndexOf and LastIndexOf
string message = "hello there!"; 

int first_h = message.IndexOf("h");
int last_h = message.LastIndexOf("h");   //returns the last occurence position of h in the message

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}");



//Retrieve the last occurence of a sub string

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf("(");

openingPosition += 1;
int closingPosition = message.LastIndexOf(")");
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));




//Retrieve the last occurence of a sub string
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf("(");
    if (openingPosition == -1) break;    //if -1 then .IndexOf can no longer find ( and exits the loop

    openingPosition += 1;
    int closingPosition = message.IndexOf(")");
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    //note the overload of the Substring to return only the remaining
    //unprocesssed message
    message = message.Substring(closingPosition + 1);  //starts from the last position and removes the first set of parenthesis 
}


//Work with different types of symbol sets

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);       //searches for multiple symbols simultaneously
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");


//Work with different types of symbol needs to match closing symbol
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);   //searches for multiple symbols simulatenously

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

}





//Use the Remove() and Replace() methods
//Remove() - use when theres a standard and consistent position of the characters you want to remove from the string, works like a substring except it deletes the specified chars

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);  //removes data between 5 and 20
Console.WriteLine(updatedData);


//Replace - is used when you need to replace one or more characters with a different character, it replaces every instance of the given characters not just the first and the last
string message = "This--is--ex-ample--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

*/



//Challenge 1
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string span = "<span>";         //constant variable value once initialized can never be changed.
const string spanClose = "</span>";
int spanLength = span.Length;       //get the length of string

int spanStartPosition = input.IndexOf(span);
spanStartPosition += spanLength;

int spanClosePosition = input.IndexOf(spanClose);
int spanPositionLength = spanClosePosition - spanStartPosition;

Console.WriteLine($"Quantity: {input.Substring(spanStartPosition, spanPositionLength)}");

const string div = "<div>";
const string divClose = "</div>";

int divStartPosition = input.IndexOf(div);

int divClosePosition = input.IndexOf(divClose);
int divPositionLength = divClosePosition - divStartPosition;
Console.WriteLine($"Output: {input.Substring(divStartPosition, divClosePosition)}");






