using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class ReservationMap:BaseMap<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Rezervasyon Bilgisi");
            Property(x => x.EntryDate).HasColumnName("Giriş Tarihi");
            Property(x => x.ReleasDate).HasColumnName("Çıkış Tarihi");
            Property(x => x.TotalPrice).HasColumnName("Toplam Ücret").HasColumnType("money");
        }
    }
}
