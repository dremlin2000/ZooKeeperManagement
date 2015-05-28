using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper.Domain.Entities
{
    public enum Gender { Male, Female }
    public class Animal
    {
        [Key]
        [MaxLength(6)]
        public string AnimalID { get; set; }
        public string AnimalType { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string StaffId { get; set; }
        public virtual Zookeeper Zookeeper { get; set; }
    }
}
