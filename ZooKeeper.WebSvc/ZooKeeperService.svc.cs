using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ZooKeeper.Domain.Abstract;

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

        public IEnumerable<DTO.ZookeeperDTO> GetZookepers()
        {
            return _repository.Zookeepers.Select(
                x => new DTO.ZookeeperDTO
                {
                    StaffID = x.StaffID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    DateOfBirth = x.DateOfBirth,
                    PhoneNumber = x.PhoneNumber
                });
        }

        public IEnumerable<DTO.AnimalDTO> GetAnimals()
        {
            throw new NotImplementedException();
        }


        public void SaveZookeper(DTO.ZookeeperDTO zookeeperDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteZookeper(string staffId)
        {
            throw new NotImplementedException();
        }

        public void SaveAnimal(DTO.AnimalDTO animalDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnimal(string animalId)
        {
            throw new NotImplementedException();
        }
    }
}
