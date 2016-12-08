using Kitapsec.Core;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapsec.Data
{
    public class KitapsecDbContext:IdentityDbContext<User>
    {
        public KitapsecDbContext(): base(DatabaseConfig.ConnectionString) //base("KitapsecDbContext")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public static KitapsecDbContext Create()
        {
            return new KitapsecDbContext();
        }
    }
}
