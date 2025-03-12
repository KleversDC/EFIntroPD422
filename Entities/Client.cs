using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFIntroPD422.Entities
{
    //Clients
    //Flights
    //Aiplanes
    [Table("Passengers")]
    class Client
    {
        public int Id { get; set; }
        //[MaxLength(100)]

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }
        //Navigation property
        public ICollection<Flight> Flights { get; set; }
    }
}
