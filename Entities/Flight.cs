namespace EFIntroPD422.Entities
{
    class Flight
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public double Rating { get; set; }
        public Airplane Airplane { get; set; }
        public int AirplaneId { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        //public Airplane Airplain { get; set; }
        public ICollection<Client> Clients { get; set; }

    }
}
