using System;
using System.Collections.Generic;
using System.Threading;
using Plane;
using Airport;

namespace Controls
{
  public static class User
  {
    public static bool InSession = true;
    public static class Input
    {
      public static string CurrentCommand;
      public static void Display()
      {
        Console.Write("ATC_Terminal_V2>");
        ReadCommand();
      }
      public static void ReadCommand()
      {
        CurrentCommand = Console.ReadLine();
        if(CurrentCommand == "$auto_update")
        {
          AutoUpdate();
        }
        if(CurrentCommand == "exit")
        {
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("EXIT_STATUS: forced");
          Console.WriteLine("");
          InSession = false;
        }
      }
      
      public static void AutoUpdate()
      {
        Console.WriteLine("FLIGHTS:");
        for(int i = 0; i<Airport.Management.Flights.Count; i++)
        {
          Console.WriteLine(Airport.Management.Flights[i]);
          
        }
        Console.WriteLine("---------------");
        Console.WriteLine("REQUESTS:");
        for(int i=0; i<Airport.Management.Requests.Count;i++)
        {
          Console.WriteLine(Airport.Management.Requests[i]);
        }
        
      }
    }
  }
  public static class World
  {
    public static Random Rand1 = new Random();
    public static void RandomEnvironment()
    {
      for(int i=0; i<Rand1.Next(0,500);i++)
      {
        new Plane.Flight();
      }
    }
  }
}