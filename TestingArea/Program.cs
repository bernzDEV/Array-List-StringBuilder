//declaring empty array of integers
using System.Collections;

int[] HarveyGrades = new int[5];

//declaring array of integers with values
double[] newGrades = { 100, 100, 100, 100, 100 };

//assigning values to the array
HarveyGrades[0] = 90;
HarveyGrades[1] = 85;
HarveyGrades[2] = 95;
HarveyGrades[3] = 100;
HarveyGrades[4] = 80;

//printing the array
foreach (int grade in HarveyGrades)
{
    Console.WriteLine(grade);
}
Console.Clear();
//printing the array 
foreach (double grade in newGrades)
{
    Console.Write(grade + " / ");
}
Console.Clear();
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//declaring an empty two dimensional array
string[,] twoDimensionalArray = new string[3,3];

//assigning values to the two dimensional array
twoDimensionalArray[1, 1] = "hello world";

//printing the value of the two dimensional array
Console.Write(twoDimensionalArray[1,1]);


Console.Clear();
/////////////////////////////////////////////////////////////////////////////////////////////
//declaring an two dimensional array
//[3,3]
//[row , column]
int[,] table =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9 },
    {10, 11, 12}
};
Console.WriteLine(table.Length);
//printing 2d array row
Console.WriteLine(table.GetLength(0));
//printing 2d array column 
Console.WriteLine(table.GetLength(1));

Console.Clear();
/////////////////////////////////////////////////////////////////////////////////////////////
int row = table.GetLength(0);
int column = table.GetLength(1);

for (int i = 0; i < row; i++)
{
    Console.Write("{");
    for (int j = 0; j < column; j++)
    {
        Console.Write(table[i, j] + ", ");
    }
    Console.Write("},");
    Console.WriteLine();
}


Console.Clear();
/////////////////////////////////////////////////////////////////////////////////////////////

ArrayList namesOf_BSCS  = new ArrayList();


for(int i = 0; i < 5; i++)
{
    Console.Write("Enter the name of the student: ");
    string name = Console.ReadLine();
    namesOf_BSCS.Add(name);
}
//"123"
foreach(string name in namesOf_BSCS)
{
    Console.WriteLine(name);
}
namesOf_BSCS.Remove("Saberon");
//namesOf_BSCS.RemoveAt(0);

Console.WriteLine("");
Console.WriteLine("After removing the first element");
foreach (string name in namesOf_BSCS)
{
    Console.WriteLine(name);
}








