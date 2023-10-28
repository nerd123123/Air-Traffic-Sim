using System;
using controls;
using plane;
using airport;
public class Program
{
  public static void Main()
  {
    Intro();
    controls.User.Input.Display();
  }
  public static void Intro()
  {
    //bool open = true;
    Console.WriteLine("Hello, Intern! Welcome to the Snekland International Airport. You are filling in for the Air Traffic Controller today.");
    Console.Write("[C]lose message>");
    var closesig = Console.ReadKey().Key.ToString().ToUpper();
    if(closesig == "C")
    {
      Console.Clear();
    }
    else
    {
      Console.Clear();
      Intro();
    }
  }
}

