using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ZooKeeper.WebUI.Models
{
    //Zookeeper view model
    public class Zookeeper
    {
        [MaxLength(6, ErrorMessage="The lenght of the Staff Id must not be more than 6 characters")]
        [Required(ErrorMessage="The Staff Id is mandatory")]
        [Display(Name = "Staff ID")]
        public string StaffID { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = "The First Name is mandatory")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "The Last Name is mandatory")]
        public string LastName { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The DOB is mandatory")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is mandatory")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}