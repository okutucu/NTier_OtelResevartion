using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Model
{
    public class RoomReservation :BaseEntity
    {
        public decimal Price { get; set; }

        public int RoomID { get; set; }
        public int ReservationID { get; set; }

        //Relational Properties

        public virtual Room Room { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
