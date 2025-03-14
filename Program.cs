using Microsoft.EntityFrameworkCore;

namespace EFIntroPD422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLinesDbContext context = new AirLinesDbContext();

            

            context.SaveChanges();
         
            var flights = context.Flights.Include(f=>f.Airplane).
                Where(f=>f.ArrivalCity == "Kyiv").OrderBy(f=> f.DepartureTime).ToList();
            foreach (var f in flights)
            {
                Console.WriteLine($"Flight: #{f.Id}, from {f.DepartureCity} to {f.ArrivalCity} at" +
                    $"{f.ArrivalTime.ToShortDateString()} airplein {f.Airplane?.Model}");
            }



            Console.WriteLine("All of clients : ");
            foreach (var client in context.Clients)
            {
                Console.WriteLine($"Client : {client.Name} - {client.Email} - {client.Birthdate}");
            }

            var cclient = context.Clients.Find(1);
            context.Entry(cclient).Collection(c => c.Flights).Load();
            Console.WriteLine($"Client : {cclient.Name} has {cclient.Flights?.Count}");

            var Flightss = context.Flights
                .Include(f => f.Clients)
                .OrderBy(f => f.DepartureTime).ToList();

            foreach (var f in Flightss)
            {
                Console.WriteLine($"#{f.Id}, From {f.ArrivalCity} to {f.ArrivalTime.ToShortDateString()}" +
                    $"Airplane: {f.Airplane?.Model} - with {f.Clients?.Count}");


            }

        }
    }
}
