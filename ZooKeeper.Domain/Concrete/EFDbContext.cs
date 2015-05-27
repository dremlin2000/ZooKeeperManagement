using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.Domain.Entities;

namespace ZooKeeper.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Zookeeper> Zookeepers { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
