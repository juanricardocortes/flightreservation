using System;

namespace main {
    class Program {

        static void Main (string[] args) {

            int intDisplayMenu = Displays.DisplayMenu ();
            if (intDisplayMenu == 1) {

                int intDisplayFlightMaintenance = Displays.DisplayFlightMaintenance ();
                if (intDisplayFlightMaintenance == 1) {
                    
                    Displays.DisplayAddFlight ();

                } else if (intDisplayFlightMaintenance == 2) {

                    int intDisplaySearchFlightMenu = Displays.DisplaySearchFlightMenu ();
                    if (intDisplaySearchFlightMenu < 1 || intDisplaySearchFlightMenu > 3) {
                        Displays.DisplayError ();
                    } else {
                        Displays.DisplaySearchFlight (intDisplaySearchFlightMenu);
                    }

                } else {
                    Displays.DisplayError ();
                }

            } else if (intDisplayMenu == 2) {

                Displays.DisplayReserveFlight ();

            } else {

                Displays.DisplayError ();

            }
        }
    }
}