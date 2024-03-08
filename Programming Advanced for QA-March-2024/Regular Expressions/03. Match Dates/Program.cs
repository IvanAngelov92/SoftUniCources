﻿using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"(?<day>\d{2})(?<separator>[./-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})";
Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(text);

foreach (Match match in matches)
{
    string day = match.Groups["day"].Value;
    string month = match.Groups["month"].Value;
    string year = match.Groups["year"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}