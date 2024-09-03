using System.Text;

string strMessage = "Hello World!";
string strMessage2 = "Hello World!";
string strPath = @"C:\TestingArea2\test.txt";
char[] word = { 'B','S','C','S','2','.','1','B' };
string strGreet = new string(word);

//Learned Keywords
//append, clear, contains, indexOf, Replace, toLower, Concat, Equals, ToString()

StringBuilder str = new StringBuilder("Compyuter ");


//StringBuilder vs Collections what are the difference

//Both of them are mutable but the difference is that StringBuilder is used for string manipulation and it is faster than Collections.
//Collections are used for storing data and it is slower than StringBuilder. 
//Collections use similar add, remove, or modify elements.
//StringBuilder use append, remove, or modify elements.
//Collections example List
//Collection also store group objects 



//String 
Console.WriteLine(strMessage);
Console.WriteLine(strPath);
Console.WriteLine(strGreet);
//Contains
Console.WriteLine(strMessage.Contains("o"));
//IndexOf
Console.WriteLine(strMessage.IndexOf("o"));
//Replace
Console.WriteLine(strMessage.Replace("l","1"));
//ToLower
Console.WriteLine(strMessage.ToLower());
//ToUpper
Console.WriteLine(strMessage.ToUpper());
//Concat
Console.WriteLine(String.Concat(strMessage," ",strGreet));
Console.WriteLine(strMessage + strGreet);

//Append
Console.WriteLine(str.Append(strMessage));
str[0] = 'K';
Console.WriteLine(str);
str.Clear();
//Clear
Console.WriteLine(str.Append("ko Ito!"));
//Equals
Console.WriteLine(strMessage.Equals(strMessage2));


//Append means to add something to the end of the string

