using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZooKeeper.WebUI.Models
{
    //Animal view model
    public class Animal
    {
        [MaxLength(6)]
        [Required(ErrorMessage = "The Animal ID is mandatory")]
        [Display(Name = "Animal ID")]
        public string AnimalID { get; set; }
        [Required(ErrorMessage = "The Animal Type is mandatory")]
        [Display(Name = "Animal Type")]
        public string AnimalType { get; set; }
        [Required(ErrorMessage = "The Nick Name is mandatory")]
        [Display(Name = "Nick Name")]
        public string NickName { get; set; }
        [Range(1, 300)]
        [Required(ErrorMessage = "The Age is mandatory")]
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "The Gender is mandatory")]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Zookeeper")]
        [Required(ErrorMessage = "The Zookeeper is mandatory")]
        public string StaffID { get; set; }
    }

    public enum Gender { Male, Female }
}