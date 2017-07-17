using System;

class AddOrSubtract
{
  static void Main()
  {
    Console.WriteLine("Give me a number: ");
    string stringUserNumber = Console.ReadLine();
    int intUserNumber = int.Parse(stringUserNumber);

    if (intUserNumber >= 0)
    {
      int intSumUserNumber = intUserNumber + 1;
      string stringSumUserNumber = intSumUserNumber.ToString();
      Console.WriteLine("Your new number is: " + stringSumUserNumber);
    }
    else
    {
      int intDifferenceUserNumber = intUserNumber - 1;
      string stringDifferenceUserNumber = intDifferenceUserNumber.ToString();
      Console.WriteLine("Your new number is: " +  stringDifferenceUserNumber);
    }
  }
}
