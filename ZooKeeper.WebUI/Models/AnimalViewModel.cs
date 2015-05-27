using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooKeeper.WebUI.Models
{
    public class AnimalViewModel
    {
        public IEnumerable<Animal> Animals { get; set; }
        //public IEnumerable<SelectListItem> MyProperty { get; set; }
    }
}