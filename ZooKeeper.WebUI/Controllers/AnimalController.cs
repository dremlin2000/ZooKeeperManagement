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
    }
}