using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class CustomerMap:BaseMap<Customer>
    {
        public CustomerMap()
        {
            Property(x => x.FirstName).HasColumnName("Isim");
            Property(x => x.LastName).HasColumnName("Soyisim");
            Property(x => x.TelNo).HasColumnName("Telefon NO");
            Property(x => x.Age).HasColumnName("Yaş");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Adress).HasColumnName("Adress");
            ToTable("Müşteriler");

        }
    }
}
