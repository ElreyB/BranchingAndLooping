using System;

class LegallyCanDrink
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string stringUserAge = Console.ReadLine();
    int intUserAge = int.Parse(stringUserAge);

    if (intUserAge >= 21)
    {
      Console.WriteLine("You are old enough to drink!");
    }
    else
    {
      Console.WriteLine("Sorry, you are not old enough to drink.");
    }
  }
}
