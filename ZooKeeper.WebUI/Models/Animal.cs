using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZooKeeper.WebUI.Models
{
    public class Animal
    {
        [Display(Name = "Animal ID")]
        public string AnimalID { get; set; }
        [Display(Name = "Animal Type")]
        public string AnimalType { get; set; }
        [Display(Name = "Nick Name")]
        public string NickName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        public Zookeeper Zookeeper { get; set; }
    }

    public enum Gender { Male, Female }
}