using System;
using System.Text.RegularExpressions;

string binary;
bool flag = false;
int result;

while (!flag)
{
    Console.WriteLine("Insert the binary number to be transformed to decimal:");
    binary = Console.ReadLine();
    if (string.IsNullOrEmpty(binary) || binary.Length > 8 || !Regex.IsMatch(binary, "^[0-1]")) {
        Console.WriteLine("The inserted value must consist only of 0 and 1, and should be under 8 digits long.");
        continue;
    }
    else {
        result = Convert.ToInt32(binary, 2);
        Console.WriteLine($"The converted decimal is: {result}");
        flag = true;
    }
}