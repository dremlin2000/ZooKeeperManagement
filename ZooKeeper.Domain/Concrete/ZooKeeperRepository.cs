using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.Domain.Abstract;
using ZooKeeper.Domain.Entities;

namespace ZooKeeper.Domain.Concrete
{
    public class ZooKeeperRepository : IZooKeeperRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Zookeeper> Zookeepers
        {
            get { return context.Zookeepers; }
        }

        public void SaveZookeeper(Zookeeper zookeeper)
        {
            context.Zookeepers.Add(zookeeper);
            context.SaveChanges();
        }

        public void DeleteZookeeper(string staffId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> Animals
        {
            get { return context.Animals; }
        }

        public void SaveAnimal(Animal animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public void DeleteAnimal(string animalId)
        {
            throw new NotImplementedException();
        }
    }
}
