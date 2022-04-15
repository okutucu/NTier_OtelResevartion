using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class HouseKeepingMap:BaseMap<HouseKeeping>
    {
        public HouseKeepingMap()
        {
            ToTable("Temizlikçiler");
            Property(x => x.Name).HasColumnName("Isim");
            Property(x => x.Surname).HasColumnName("Soyisim");
            Property(x => x.Salary).HasColumnName("Maaş").HasColumnType("money");
            Property(x => x.KeepingSeniority).HasColumnName("Kıdem");
        }
    }
}
