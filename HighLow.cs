using System;

class Program
{
  public static int high = 101;
  public static int low = 1;
  public static void Main()
  {
    int currentNum = (high + low)/2;
    Console.WriteLine("Pick a number between 1 and 100, don't tell me it...");
    Console.WriteLine("Is your number higher or lower than " + currentNum + "? (Higher/Lower/Correct)");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "Higher")
    {
      low = currentNum;
      Main();
    }
    else if (userAnswer == "Lower")
    {
      high = currentNum;
      Main();
    }
    else if (userAnswer == "Correct")
    {
      Console.WriteLine("Your number was " + currentNum);
    }

  }
}