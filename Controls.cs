using System;
using System.Collections.Generic;
using System.Threading;
using Plane;
using Airport;

namespace Controls
{
  public static class User
  {
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
        if(CurrentCommand == "AUT_UP()")
        {
          AutoUpdate();
        }
      }
      public static void ReadSignal(string flightnum, string instruction)
      {
        if (instruction == "land")
        {
          
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
}