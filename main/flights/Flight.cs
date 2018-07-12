namespace main {
    public class Flight {
        public Flight (string strAirlineCode, string strFlightNumber, string strArrivalStation, string strDepartureStation, string strSTA, string strSTD) {
            this.strAirlineCode = strAirlineCode;
            this.strFlightNumber = strFlightNumber;
            this.strArrivalStation = strArrivalStation;
            this.strDepartureStation = strDepartureStation;
            this.strSTA = strSTA;
            this.strSTD = strSTD;
        }
        public string strAirlineCode { get; set; }
        public string strFlightNumber { get; set; }
        public string strArrivalStation { get; set; }
        public string strDepartureStation { get; set; }
        public string strSTA { get; set; }
        public string strSTD { get; set; }
    }
}