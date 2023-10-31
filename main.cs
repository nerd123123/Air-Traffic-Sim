using System;
using Controls;
using Plane;
using Airport;
public class Program
{
  public static void Main()
  {
    Intro();
    Controls.User.Input.Display();
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

