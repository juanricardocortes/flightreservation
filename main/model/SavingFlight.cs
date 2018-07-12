using System;
using System.IO;

namespace main {
    public class SavingFlight {
        public static void SaveFlight (Flight flight) {
            string newFileName = "C:\\Users\\jcortes\\Desktop\\FlightReservation\\main\\flights\\SavedFlights.csv";
            string clientDetails = flight.strAirlineCode + "," +
                flight.strFlightNumber + "," +
                flight.strDepartureStation + "," +
                flight.strArrivalStation + "," +
                flight.strSTA + "," +
                flight.strSTD +
                Environment.NewLine;
            if (!File.Exists (newFileName)) {
                string clientHeader = "Airline Code" + "," + "Flight Number" + "," + "Departure Station" + "," + "Arrival Station" + "," + "STA" + "," + "STD" + Environment.NewLine;
                File.WriteAllText (newFileName, clientHeader);
            }
            File.AppendAllText (newFileName, clientDetails);
        }
    }
}