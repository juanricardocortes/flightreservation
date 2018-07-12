using System;
using System.Collections.Generic;
using System.IO;

namespace main {
    public class SearchingFlight {
        public static string strFilter { get; set; }
        public static int intColumnNumber;
        public static void SearchFlight (int option) {
            if (option == 1) {
                SearchByFlightNumber ();
            } else if (option == 2) {
                SearchByAirlineCode ();
            } else if (option == 3) {
                SearchByOriginDestination ();
            }
        }

        public static void SearchByFlightNumber () {
            Console.Write ("\nEnter flight number: ");
            strFilter = Console.ReadLine ();
            intColumnNumber = 1;
            Displays.DisplaySearchedFlights (CompareString ());
        }

        public static void SearchByAirlineCode () {
            Console.Write ("\nEnter Airline code: ");
            strFilter = Console.ReadLine ();
            intColumnNumber = 0;
            Displays.DisplaySearchedFlights (CompareString ());
        }

        public static void SearchByOriginDestination () {
            Console.Write ("\nEnter origin: ");
            strFilter = Console.ReadLine ();
            Console.Write ("\nEnter destination: ");
            strFilter += Console.ReadLine ();
            intColumnNumber = 2;
            Displays.DisplaySearchedFlights (CompareString ());
        }

        public static List<Flight> CompareString () {
            List<Flight> flightList = new List<Flight> ();
            foreach (Flight flight in GetFlights.GetAllFlights ()) {
                if (intColumnNumber == 2) {
                    if ((flight.strDepartureStation + flight.strArrivalStation) == strFilter) {
                        flightList.Add (flight);
                    }
                } else if (intColumnNumber == 1) {
                    if (flight.strFlightNumber == strFilter) {
                        flightList.Add (flight);
                    }
                } else if (intColumnNumber == 0) {
                    if (flight.strAirlineCode == strFilter) {
                        flightList.Add(flight);
                    }
                }
            }
            return flightList;
        }
    }
}