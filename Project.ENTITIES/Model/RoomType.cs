using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Enum;

namespace Project.ENTITIES.Model
{
    public class RoomType :BaseEntity
    {
        public RoomTypeEnum RoomTypeName { get; set; }
        public string Description { get; set; }
        public string SpeacialService { get; set; }
        

        // Relational Properties

        public virtual List<Room> Rooms { get; set; }
    }
}
