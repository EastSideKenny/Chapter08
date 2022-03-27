using static System.Console;

WorkingWithLists();

static void Output(string title, IEnumerable<string> collection)
{
    WriteLine(title);
    foreach (string item in collection)
    {
        WriteLine($"    {item}");
    }
}

static void WorkingWithLists()
{
    // Simple syntax for creating a list and adding three items
    List<string> cities = new();
    cities.Add("London");
    cities.Add("Paris");
    cities.Add("Luxembourg");

    /* Alternative syntax that is converted by the compiler into
       the three Add method calls above
       List<string> cities = new()
        { "London", "Paris", "Luxembourg" };
     */

    Output("Initial list", cities);

    WriteLine($"The first city is {cities[0]}.");
    WriteLine($"The last city is {cities[cities.Count - 1]}.");

    cities.Insert(0, "Sydney");

    Output("After inserting Sydney at index 0", cities);

    cities.RemoveAt(1);
    cities.Remove("Luxembourg");

    Output("After removing two cities", cities);
}