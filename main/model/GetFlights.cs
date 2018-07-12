using System.Collections.Generic;
using System.IO;

namespace main {
    public class GetFlights {
        public static List<Flight> GetAllFlights () {

            List<Flight> flightList = new List<Flight> ();
            string line = null;
            using (StreamReader reader = File.OpenText (@"C:\Users\jcortes\Desktop\FlightReservation\main\flights\SavedFlights.csv")) {
                while ((line = reader.ReadLine()) != null) {
                    var values = line.Split (',');
                    Flight flight = new Flight (values[0], values[1], values[3], values[2], values[4], values[5]);
                    flightList.Add (flight);
                }
            }
            return flightList;
        }
    }
}