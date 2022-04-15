using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class RoomMap:BaseMap<Room>
    {
        public RoomMap()
        {
            ToTable("Odalar");
            Property(x => x.RoomNo).HasColumnName("Oda Numarası");
            Property(x => x.RoomPrice).HasColumnName("Oda Numarası").HasColumnType("money");
        }
    }
}
