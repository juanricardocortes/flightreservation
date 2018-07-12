using System;
using System.Collections.Generic;

namespace main {
    public class Displays {
        public static int DisplayMenu () {
            Console.WriteLine ("[1] Flight Maintenance");
            Console.WriteLine ("[2] Flight Reservation");
            Console.Write ("Hello! Select one of the options: ");
            return Convert.ToInt32 (Console.ReadLine ());
        }

        public static int DisplayFlightMaintenance () {
            Console.Clear ();
            Console.WriteLine ("[1] Add Flight");
            Console.WriteLine ("[2] Search Flight");
            Console.Write ("Choose one of the options: ");
            return Convert.ToInt32 (Console.ReadLine ());
        }

        public static void DisplayAddFlight () {
            Console.Clear ();
            AddingFlight.AddFlight ();
        }

        public static int DisplaySearchFlightMenu () {
            Console.Clear ();
            Console.WriteLine ("[1] Search by flight number");
            Console.WriteLine ("[2] Search by airline code");
            Console.WriteLine ("[3] Search by origin/destination");
            Console.Write ("Choose one of the options: ");
            return Convert.ToInt32 (Console.ReadLine ());
        }

        public static void DisplaySearchFlight (int option) {
            Console.Clear ();
            SearchingFlight.SearchFlight (option);
        }

        public static void DisplaySearchedFlights (List<Flight> flights) {
            Console.WriteLine("Search Results");
            for (int i = 0; i < flights.Count; i++) {
                Console.WriteLine("Airline code: " + flights[i].strAirlineCode);
                Console.WriteLine("Flight number: " + flights[i].strFlightNumber);
                Console.WriteLine("Arrival station: " + flights[i].strArrivalStation);
                Console.WriteLine("Departure station: " + flights[i].strDepartureStation);
                Console.WriteLine("Scheduled time of arrival: " + flights[i].strSTA);
                Console.WriteLine("Scheduled time of departure: " + flights[i].strSTD);
                Console.WriteLine ("----------------------------------------------");
            }
        }

        public static void DisplayReserveFlight () {
            Console.WriteLine ("Reserve flights");
        }

        public static void DisplayError () {
            Console.WriteLine ("Invalid input");
        }
    }
}