using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooKeeper.WebUI.ZookeeperWebSvc;

namespace ZooKeeper.WebUI.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IZooKeeperService _websvc;

        public AnimalController(IZooKeeperService websvc)
        {
            _websvc = websvc;
        }

        // GET: Animal
        public ActionResult Index()
        {
             ZookeeperWebSvc.AnimalDTO[] animals = _websvc.GetAnimals();
             Mapper.CreateMap<ZookeeperWebSvc.AnimalDTO, ZooKeeper.WebUI.Models.Animal>();
             return View(Mapper.Map<ZookeeperWebSvc.AnimalDTO[], ZooKeeper.WebUI.Models.Animal[]>(animals));
        }

        // GET: Animal/Create
        public ActionResult Create()
        {
            ViewBag.ZookeeperSelection = _websvc.GetZookepers().Select(
                x => new SelectListItem
                {
                    Value = x.StaffID.ToString(),
                    Text = String.Format("{0} {1}: {2}", x.FirstName, x.LastName, x.StaffID) });
            return View(new ZooKeeper.WebUI.Models.Animal());
        }

        // POST: Animal/Create
        [HttpPost]
        public ActionResult Create(ZooKeeper.WebUI.Models.Animal animal)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<ZooKeeper.WebUI.Models.Animal, ZookeeperWebSvc.AnimalDTO>();
                _websvc.SaveAnimal(Mapper.Map<ZookeeperWebSvc.AnimalDTO>(animal));
                TempData["message"] = string.Format("{0} has been saved", animal.NickName);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(animal);
            }
        }
    }
}