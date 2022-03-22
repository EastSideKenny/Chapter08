using static System.Console;

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");

WriteLine($"First char is {city[0]} and third is {city[2]}.");

WriteLine();

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";
string[] citiesArray = cities.Split(',');

WriteLine($"There are {citiesArray.Length} items in the array.");
foreach (string item in citiesArray)
{
    WriteLine(item);
}

WriteLine();

string fullName = "Jérôme Jacob";
int indexOfTheSpace = fullName.IndexOf(' ');

string firstName = fullName.Substring(
    startIndex: 0, length: indexOfTheSpace);

string lastName = fullName.Substring(indexOfTheSpace + 1);

WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

string fullName2 = "Jones, Alan";
int indexOfComma = fullName2.IndexOf(',');
int indexOfSpace = fullName2.IndexOf(' ');

string firstName2 = fullName2.Substring(
    startIndex: indexOfSpace + 1);

string lastName2 = fullName2.Substring(
    startIndex: 0, length: indexOfComma);

WriteLine($"Original 2: {fullName2}");
WriteLine($"Swapped 2: {firstName2} {lastName2}");

WriteLine();

string company = "Microsoft";
bool startsWithM = company.StartsWith("M");
bool containsN = company.Contains("N");
WriteLine($"Text: {company}");
WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");

WriteLine();

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

WriteLine();

string fruit = "Apples";
decimal price = 0.39M;
DateTime when = DateTime.Now;

WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");

WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
    arg0: fruit, arg1: price, arg2: when));