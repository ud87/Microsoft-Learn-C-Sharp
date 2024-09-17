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


*/





