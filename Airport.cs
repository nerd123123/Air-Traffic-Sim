using System;
using Plane;
using Controls;
using System.Collections.Generic;
namespace Airport
{
  public static class Management
  {
    public static List<string> Flights = new List<string>();
    public static List<string> Requests = new List<string>();
  }
  public class Hangar
  {
    public bool Full = false;
    public Hangar(string HangarCode, int HangarSize)
    {
      
    }
  }
}