using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class Ticketservice
    {
        static List<Ticket> Ticket  { get; }
        static int nextId = 3;
        static Ticketservice()
        {
            Ticket = new List<Ticket>
                {
                    new Ticket { Id = 1, Name = "Classic Italian", Price=200 },
                    new Ticket { Id = 2, Name = "Veggie", Price=1500 }
                };
        }

        public static List<Ticket> GetAll() => Ticket;

        public static Ticket? Get(int id) => Ticket.FirstOrDefault(p => p.Id == id);

        public static void Add(Ticket ticket)
        {
            ticket.Id = nextId++;
            Ticket.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Ticket.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Ticket.FindIndex(p => p.Id == ticket.Id);
            if (index == -1)
                return;

            Ticket[index] = ticket;
        }

    }
}
