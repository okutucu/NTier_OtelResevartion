using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Model
{
    public class Room : BaseEntity
    {
        public int RoomNo { get; set; }
        public decimal RoomPrice { get; set; }
        public int? HouseKeepingID { get; set; }
        public int? OtelID { get; set; }
        public int? RoomTypeID { get; set; }
        


        //Relational Properties
        public virtual Otel Otel { get; set; }

        public virtual HouseKeeping HouseKeeping { get; set; }

        public virtual List<RoomReservation> RoomReservations { get; set; }

        public virtual RoomType RoomType { get; set; }
    }

}
