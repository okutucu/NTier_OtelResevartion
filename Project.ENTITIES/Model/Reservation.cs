using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Enum;

namespace Project.ENTITIES.Model
{
    public class Reservation : BaseEntity
    {
        public DateTime EntryDate { get; set; }
        public DateTime ReleasDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int? Discont { get; set; }
        public ReservationTypeEnum ReservationType { get; set; }
        public int? CustomerID { get; set; }
        public int? OtelID { get; set; }


        //Relational Properties

        public virtual Customer Customer { get; set; }
        public virtual Otel Otel { get; set; }

        public virtual List<RoomReservation> RoomReservations { get; set; }

    }
}
