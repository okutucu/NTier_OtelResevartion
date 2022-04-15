using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Model
{
    public class Customer :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Age { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        // Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        
    }
}
