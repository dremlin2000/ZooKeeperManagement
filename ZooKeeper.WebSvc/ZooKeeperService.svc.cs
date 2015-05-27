using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ZooKeeper.Domain.Abstract;
using ZooKeeper.Domain.Entities;

namespace ZooKeeper.WebSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ZooKeeperService : IZooKeeperService
    {
        // <summary>
        /// Reference to the ZooKeeper repository
        /// </summary>
        private readonly IZooKeeperRepository _repository;


        /// <summary>
        /// Contructor that takes in depenencies to allow for unit testing.
        /// </summary>
        /// <param name="repository"></param>
        public ZooKeeperService(IZooKeeperRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Method that retrieves all zookeepers to the database
        /// </summary>
        public IEnumerable<DTO.ZookeeperDTO> GetZookepers()
        {
            Mapper.CreateMap<Zookeeper, DTO.ZookeeperDTO>();
            return Mapper.Map<Zookeeper[], DTO.ZookeeperDTO[]>(_repository.Zookeepers.ToArray<Zookeeper>());
        }

        /// <summary>
        /// Method that retrieves all animals to the database
        /// </summary>
        public IEnumerable<DTO.AnimalDTO> GetAnimals()
        {
            Mapper.CreateMap<Animal, DTO.AnimalDTO>();
            return Mapper.Map<Animal[], DTO.AnimalDTO[]>(_repository.Animals.ToArray<Animal>());
        }

        /// <summary>
        /// Method that saves a zookeeper to the database
        /// </summary>
        public void SaveZookeper(DTO.ZookeeperDTO zookeeperDTO)
        {
            Mapper.CreateMap<DTO.ZookeeperDTO, Domain.Entities.Zookeeper>();
            _repository.SaveZookeeper(Mapper.Map<Domain.Entities.Zookeeper>(zookeeperDTO));
        }

        public void DeleteZookeper(string staffId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method that saves an animal to the database
        /// </summary>
        public void SaveAnimal(DTO.AnimalDTO animalDTO)
        {
            Mapper.CreateMap<DTO.AnimalDTO, Domain.Entities.Animal>();
            _repository.SaveAnimal(Mapper.Map<Domain.Entities.Animal>(animalDTO));
        }

        public void DeleteAnimal(string animalId)
        {
            throw new NotImplementedException();
        }
    }
}
