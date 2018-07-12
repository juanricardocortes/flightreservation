using System;

namespace main {
    public class AddingFlight {

        public static void AddFlight () {

            Console.Write ("\nEnter airline code: ");
            string strAirlineCode = Console.ReadLine ();
            Console.Write ("\nEnter flight number: ");
            string strFlightNumber = Console.ReadLine ();
            Console.Write ("\nEnter arrival station: ");
            string strArrivalStation = Console.ReadLine ();
            Console.Write ("\nEnter departure station: ");
            string strDepartureStation = Console.ReadLine ();
            Console.Write ("\nEnter scheduled time of arrival to {0}: ", strArrivalStation);
            string strSTA = Console.ReadLine ();
            Console.Write ("\nEnter scheduled time of departure from {0}: ", strDepartureStation);
            string strSTD = Console.ReadLine ();

            Flight flight = new Flight (strAirlineCode, strFlightNumber, strArrivalStation, strDepartureStation, strSTA, strSTD);
            SavingFlight.SaveFlight(flight);
        }
    }
}