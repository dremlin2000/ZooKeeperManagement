using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooKeeper.WebUI.Models;
using ZooKeeper.WebUI.ZookeeperWebSvc;

namespace ZooKeeper.WebUI.ZookeeperWebSvc
{
    public class ZookeeperController : Controller
    {
        private readonly IZooKeeperService _websvc;
        public ZookeeperController(IZooKeeperService websvc)
        {
            _websvc = websvc;
        }
        
        // GET: Zookeeper
        public ActionResult Index()
        {
            Mapper.CreateMap<ZookeeperWebSvc.ZookeeperDTO, ZooKeeper.WebUI.Models.Zookeeper>();
            return View(Mapper.Map<ZookeeperWebSvc.ZookeeperDTO[], ZooKeeper.WebUI.Models.Zookeeper[]>(_websvc.GetZookepers()));
        }

        // GET: Zookeeper/Create
        public ActionResult Create()
        {
            return View(new ZooKeeper.WebUI.Models.Zookeeper());
        }

        // POST: Zookeeper/Create
        [HttpPost]
        public ActionResult Create(ZooKeeper.WebUI.Models.Zookeeper zookeeper)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<ZooKeeper.WebUI.Models.Zookeeper, ZookeeperWebSvc.ZookeeperDTO>();
                _websvc.SaveZookeper(Mapper.Map<ZookeeperWebSvc.ZookeeperDTO>(zookeeper));
                TempData["message"] = string.Format("{0} {1} has been saved", zookeeper.FirstName, zookeeper.LastName);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(zookeeper);
            }
        }
    }
}
