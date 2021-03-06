using static System.Console;
using System.Globalization;

WriteLine("Earliest date/time value is: {0}",
    arg0: DateTime.MinValue);

WriteLine("UNIX epoch date/time value is: {0}",
    arg0: DateTime.UnixEpoch);

WriteLine("Date/time value Now is: {0}",
    arg0: DateTime.Now);

WriteLine("Date/time value Today is: {0}",
    arg0: DateTime.Today);

WriteLine();

DateTime christmas = new(year: 2022, month: 12, day: 25);

WriteLine("Christmas: {0}",
    arg0: christmas); // default format

WriteLine("Christmas: {0:dddd, dd MMMM yyyy}",
    arg0: christmas); // custom format

WriteLine("Christmas is day {0} of the year.",
    arg0: christmas.DayOfYear);

WriteLine("Christmas {0} is on a {1}.",
    arg0: christmas.Year,
    arg1: christmas.DayOfWeek);

WriteLine();

WriteLine("Current culture is: {0}",
    arg0: CultureInfo.CurrentCulture.Name);

string textDate = "4 July 2021";
DateTime independeceDay = DateTime.Parse(textDate);

WriteLine("Text: {0}, DateTime: {1:d MMMM}",
    arg0: textDate,
    arg1: independeceDay);