using System;

class HasTwoDigits
{
  static void Main()
  {
    Console.WriteLine("Give me a whole number:");
    string stringUserNumber = Console.ReadLine();
    int intUserNumber = int.Parse(stringUserNumber);
    Console.WriteLine(intUserNumber >= 10);
  }
}
