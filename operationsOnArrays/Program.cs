/*
string[] pallets = {"B14", "A11", "B12", "A13"};

Console.WriteLine("Sorted...");
Array.Sort(pallets);        //sorts in alphabetical order
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);     //sorts in reverse order
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

*/


//Ex 1 Use array methods to clear and resize an array
//Array.Clear() method allows to remove the specific contents of specific elememts in array and replace it with the array default value (for int its 0, for string its null)
//Array.Resize() method adds or removes elements from array

/*
string[] pallets = {"B14", "A11", "B12", "A13"};
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);  //clear array elements starting at 0 and clear 2 elements
if (pallets[0] != null)
    Console.WriteLine($"Before: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


//Resize the array to add more elements
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);           //increases the pallet size to 6 elements from 4 elements if not used will get an out of bound error
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";         //adds new elements
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//We cannot directly remove null elements from an array due to Array.Clear() method. Best way to remove is to create a 2nd array and copy non null values into new array



//ToCharArray() to reverse a string
string value = "abc123";
char[] valueArray = value.ToCharArray();  //converts string to array
Array.Reverse(valueArray);                  //reverses an array
// string result = new string(valueArray);     //convert array back to string
string result = string.Join(",", valueArray);

string[] items = result.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);
}


//ex1 complete a challenge to reverse words in a sentence
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");   //split into words array
string[] wordsReversed = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] charPangramArray = words[i].ToCharArray();  //split word into individual array
    Array.Reverse(charPangramArray);                       //reverse the word
    wordsReversed[i] = new string(charPangramArray);
}

string result = string.Join(" ", wordsReversed);
Console.WriteLine(result);

*/

//ex2 complete a challenge to parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//parse and store order IDs to array
string[] orderStreamArray = orderStream.Split(",");

//Sort Array
Array.Sort(orderStreamArray);

//loop through the array 
for (int i = 0; i<orderStreamArray.Length; i++)
{
    //check if array length is equal to 4
    if (orderStreamArray[i].Length == 4)
    {
        Console.WriteLine(orderStreamArray[i]);
    }
    else 
    {
        Console.WriteLine($"{orderStreamArray[i]}\t\t-Error");
    }
}
    



