/*
//Methods can provide return values after performing their tasks, this allows us to use values returned by functions

//using void as the return type means the method only perfoms operations and doesn't return a value
double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    //Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);

}

bool TotalMeetsMinimum()
{
    //Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    //Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}



//Return numbers from methods
string input = "";
double usd = 0;

do
{
    Console.WriteLine("Please enter the amount in USD: ");
    input = Console.ReadLine();
} while (!double.TryParse(input, out usd) && usd < 0);   //runs till input is not a number and input is less than 0 


int vnd = USDToVnd(usd);
int npr = USDToNPR(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${usd} USD = ${npr} NPR");

int USDToVnd(double usd)     //main signature method must have data type specified
{
    int rate = 23500;
    return (int)(rate * usd);   //return data type must match the signature data type
}

int USDToNPR(double usd)
{
    int rate = 70;
    return (int)(rate * usd);
}





//Return strings from methods
//Reverse a string

string input = "I am a man";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));


//Reverse each word in a given sentence
string ReverseSentence(string sentence)
{
    //split sentence into individual words, splitter " " and store it to an array
    string[] sentenceArr = sentence.Split(" ");

    string result = "";

    foreach (string s in sentenceArr)
    {
        result += ReverseWord(s) + " ";
    }

    return result = result.Trim();
}

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}



//Return Booleans from methods
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }
    return true;
}


//Return strings, boolean from methods added to methodsThatReturnValues

//Return arrays from methods
//Find two coins whose sum is equal to a target value
int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result;
}

*/


//Excercise - complete the challenge to add methods to make the game playable

Random random = new Random();
string answer = "";

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}


bool ShouldPlay()
{
    answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        return true;
    }
    else return false;

}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 5); //generate a random number between 1 and 5
        var roll = random.Next(1, 5);   //generate a random number between 1 and 5

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You win!" : "You lose!";
}