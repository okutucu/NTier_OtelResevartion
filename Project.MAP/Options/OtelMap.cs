using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class OtelMap:BaseMap<Otel>
    {
        public OtelMap()
        {
            ToTable("Otel bilgileri");
            Property(x => x.Name).HasColumnName("Otel Adı");
            Property(x => x.Description).HasColumnName("Otel Açıklaması");
        }
    }
}
