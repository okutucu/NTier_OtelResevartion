using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Model;

namespace Project.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanıcılar");
            Property(x => x.UserName).HasColumnName("Kullanıcı İsmi").IsRequired();
            Property(x => x.Password).HasColumnName("Şifre").IsRequired().HasMaxLength(8);

            HasOptional(x => x.Customer).WithRequired(x => x.AppUser);


        }
    }
}
