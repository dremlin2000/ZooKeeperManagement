using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ZooKeeper.WebSvc.DTO
{
    [DataContract]
    public class ZookeeperDTO
    {
        [DataMember]
        public string StaffID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public DateTime? DateOfBirth { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}