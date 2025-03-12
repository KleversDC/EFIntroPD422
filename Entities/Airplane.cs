using System.ComponentModel.DataAnnotations;

namespace EFIntroPD422.Entities
{
    class Airplane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int MaxPassengers { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
