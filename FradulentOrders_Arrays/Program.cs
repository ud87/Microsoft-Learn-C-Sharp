/*
//Declare a new array
string[] fradulentOrderIDs = new string[3]; //creates a new instance of an array in pc memory that can hold 3 string values

//Assign values to elements of an array
fradulentOrderIDs[0] = "A213";
fradulentOrderIDs[1] = "B456";
fradulentOrderIDs[2] = "C789";
//fradulentOrderIDs[3] = "D000";
*/

string[] fradulentOrderIDs = ["A213", "B456", "C789", "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];      //collection expression syntax can also use {} instead of []

Console.WriteLine($"First: {fradulentOrderIDs[0]}");
Console.WriteLine($"Second: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third: {fradulentOrderIDs[2]}");

fradulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fradulentOrderIDs[0]}");

//length of an array can be found using .Length property
Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process.\n");

//Finds and prints all the fraudlentOrderId's starting with "B
foreach (string fradulentOrderId in fradulentOrderIDs)
{
    if (fradulentOrderId.StartsWith("B"))
    {
        Console.WriteLine(fradulentOrderId);
    }
}
