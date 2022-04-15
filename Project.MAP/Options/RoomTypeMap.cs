using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class RoomTypeMap: BaseMap<RoomType>
    {
        public RoomTypeMap()
        {

            ToTable("Oda Tipleri");
            Property(x => x.RoomTypeName).HasColumnName("Oda Tipi");
           
         
        }
    }
}
