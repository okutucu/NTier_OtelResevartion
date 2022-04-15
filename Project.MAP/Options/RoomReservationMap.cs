using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class RoomReservationMap : BaseMap<RoomReservation>
    {
        public RoomReservationMap()
        {
            ToTable("RezervasyonOda");
            Property(x => x.Price).HasColumnName("Ücret").HasColumnType("money");

            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.RoomID,
                x.ReservationID
            });
        }
    }
}
