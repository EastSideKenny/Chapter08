using System;
using static System.Console;

string name = "Samantha Jones";

// Using Substring
WriteLine(name.Length);
int lengthOfFirst = name.IndexOf(' ');
WriteLine(lengthOfFirst);
int lengthOfLast = name.Length - lengthOfFirst - 1;
WriteLine(lengthOfLast);

string firstName = name.Substring(
    startIndex: 0,
    length: lengthOfFirst);

string lastName = name.Substring(
    startIndex : name.Length - lengthOfLast,
    length: lengthOfLast);

WriteLine($"First name: {firstName}, Last name: {lastName}");

// Using Spans

ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..^0];

WriteLine("First name: {0}, Last name: {1}",firstNameSpan.ToString(),lastNameSpan.ToString());