using System.Text.RegularExpressions;
using static System.Console;

Write("Enter your age: ");
string? input = ReadLine();

Regex ageChecker = new(@"^\d+$");

if (ageChecker.IsMatch(input))
{
    WriteLine("Thank you!");
}
else
{
    WriteLine($"This is not a valid age: {input}");
}