using System;
using System.Collections.Generic;
using System.Threading;
using Controls;
using Airport;

namespace Plane
{
  public class Flight
  {
    public string AirlineCode;
    public string FlightNumber;
    public Flight()
    {
      RandomAirline();
      Airport.Management.TotalFlights++;
      FlightNumber = AirlineCode + Airport.Management.TotalFlights.ToString();
      Airport.Management.Flights.Add(FlightNumber);
    }
    private void RandomAirline()
    {
      Random RandomSelector = new Random();
      AirlineCode = Airport.Airlines.AirlineNames[RandomSelector.Next(0,Airport.Airlines.AirlineNames.Length)];
    }

  }
}