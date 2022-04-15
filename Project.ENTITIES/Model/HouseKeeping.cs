using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Enum;

namespace Project.ENTITIES.Model
{
    public class HouseKeeping : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public HouseKeepingEnum KeepingSeniority { get; set; }

        public int? OtelID { get; set; }

        // Relational Properties

        public virtual Otel Otel { get; set; }
        public virtual List<Room> Rooms { get; set; }
    }

}
