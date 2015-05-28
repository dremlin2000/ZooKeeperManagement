using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeper.Domain.Entities;

namespace ZooKeeper.Domain.Abstract
{
    public interface IZooKeeperRepository
    {
        IEnumerable<Zookeeper> Zookeepers { get; }
        void SaveZookeeper(Zookeeper zookeeper);
        void DeleteZookeeper(string staffId);
        IEnumerable<Animal> Animals { get; }
        void SaveAnimal(Animal animal);
        void DeleteAnimal(string animalId);
    }
}
