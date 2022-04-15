using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Model
{
    public class Otel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

       

        // Relational Properties

        public virtual List<Room> Rooms { get; set; }
        public virtual List<HouseKeeping> HouseKeepings { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

    }
}
