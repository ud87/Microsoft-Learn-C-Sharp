using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};


PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}


void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);    //generate a random number between i and length of pettingZoo, improves the distribution

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];     //swap through each element in the array and swap it with a random element
        pettingZoo[r] = temp;              //swap the random element with the element it replaced so no duplicates are present
    }

}


//assigns the petting zoo animals to groups

string[,] AssignGroup(int groups = 6)      //optional default parameter 6 but group size can be more or less than this, no of animals in group
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)    //result.GetLength(1) gets the length of the column
        {
            result[i, j] = pettingZoo[start++];     //assigns petting zoo animals to designated number of groups
        }
    }
    return result;
}


//Print group
void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)      //get the rows of array
    {
        for (int j = 0; j < group.GetLength(1); j++)   //get the column of array
        {
            Console.Write($"{group[i, j]} ");
        }
        Console.WriteLine();    //print extra spaces between teh animal groups
    }
}