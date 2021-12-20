using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public uint Price { get; set; }
        public DateTime DateEvent { get; set; }
        public Guid ClientId { get; set; }
        public ICollection<Client> Client { get; set; }
        public Guid EventId { get; set; }
        public ICollection<Event> Event { get; set; }
    }
}
