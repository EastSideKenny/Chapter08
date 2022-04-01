using static System.Console;
using System.Text.RegularExpressions;

WriteLine("The default regular expression checks for at least one digit.");
Write("Enter a regular expression (or press ENTER to use the default): ");
string? regInput = ReadLine();
Regex regEx;

if (!String.IsNullOrEmpty(regInput))
{
    regEx = new(regInput);
}else
{
    regEx = new("^[0-9]{1,}");  // correct regex : ^ <- Start of input / \d <- single digit / + <- one or more / $ <- end of input
}

WriteLine();
Write("Enter some input: ");
string? input = ReadLine();
WriteLine($"{input} matches {regEx.ToString()} {regEx.IsMatch(input)}");
