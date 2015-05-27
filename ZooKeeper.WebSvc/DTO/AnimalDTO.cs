using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ZooKeeper.WebSvc.DTO
{
    [DataContract]
    public enum Gender 
    {
        [EnumMember]
        Male,
        [EnumMember]
        Female 
    }

    [DataContract]
    public class AnimalDTO
    {
        [DataMember]
        public string AnimalID { get; set; }
        [DataMember]
        public string AnimalType { get; set; }
        [DataMember]
        public string NickName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public Gender Gender { get; set; }
        [DataMember]
        public string StaffID { get; set; }
    }
}