using System;
using System.Collections.Generic;
using plane;
using airport;

namespace controls
{
  public static class User
  {
    public static class Input
    {
      public static void Display()
      {
        Console.Write("ATC_Terminal_V2>");
      }
      public static void ReadCommand()
      {
        
      }
      public static void ReadSignal(string flightnum, string instruction)
      {
        if (instruction == "land")
        {
          
        }
      }
    }
  }
}