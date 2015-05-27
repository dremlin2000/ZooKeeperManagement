using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ZooKeeper.WebSvc.DTO;

namespace ZooKeeper.WebSvc
{
    [ServiceContract]
    public interface IZooKeeperService
    {
        [OperationContract]
        IEnumerable<ZookeeperDTO> GetZookepers();
        [OperationContract]
        void SaveZookeper(ZookeeperDTO zookeeperDTO);
        [OperationContract]
        void DeleteZookeper(string staffId);

        [OperationContract]
        IEnumerable<AnimalDTO> GetAnimals();
        [OperationContract]
        void SaveAnimal(AnimalDTO animalDTO);
        [OperationContract]
        void DeleteAnimal(string animalId);
    }
}
