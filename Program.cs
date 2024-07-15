//EX1

// void Main()
// {
//     char[,] chars = { {'a', 'b', 'c', 'd'} , {'q', 'w', 'e', 'r'}};
//     System.Console.WriteLine(CharsToString(chars));
// }

// string CharsToString(char[,] chars)
// {
//     string str = "";
//     // for(int i = 0; i < chars.GetLength(0); i++)
//         // for(int j = 0; j < chars.GetLength(1); j++)
//     foreach(char c in chars)
//         str += c;
//     return str;
// }

// Main();


//ex2

// using System.Net.Security;

// void Main()
// {
//     string text = "Hello World";
//     System.Console.WriteLine(strTolower(text));
// }

// string strTolower(string str)
// {
//     str = str.ToLower();
//     return str; 
// }

// Main();


//ex3

// void Main()
// {
//     string text = "шалаш";
//     System.Console.WriteLine(IsPalindrom(text));
// }

// bool IsPalindrom(string str)
// {
//     for(int i = 0; i < str.Length; i++)
//         if(str[i] != str[str.Length - i - 1]) 
//             return false;
//     return true;
// }

// Main();