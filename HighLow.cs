using System;

class Program
{
  public static int currentNum = 50;
  public static void Main()
  {
    Console.WriteLine("Pick a number between 1 and 100, don't tell me it...");
    Console.WriteLine("Is your number higher or lower than " + currentNum + "? (Higher/Lower/Correct)");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "Higher")
    {
      Higher(currentNum);
      Main();
    }
    else if (userAnswer == "Lower")
    {
      Lower(currentNum);
      Main();
    }
    else if (userAnswer == "Correct")
    {
      Console.WriteLine("Your number was" + currentNum);
    }

  }
  public static void Higher(int inputNum)
  {
    currentNum += ((100 - inputNum) / 2);
  }
  public static void Lower(int inputNum)
  {
    currentNum -= (inputNum / 2);
  }
}