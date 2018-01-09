using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Planb.Entities;

namespace Planb.data.code
{
    public class context : DbContext

    {
        public DbSet<postoffice> postoffice { get; set; }
    }
}
