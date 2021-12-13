using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.WebApi.Models
{
    public class CreateClientRandom
    {
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }
        public List<string> MiddleName { get; set; }
        public List<DateTime> Birthday { get; set; }
    }
}
