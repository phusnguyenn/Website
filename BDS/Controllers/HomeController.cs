using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDS.Models;

namespace BDS.Controllers
{
    public class HomeController : Controller
    {
        HomeDataEntities2 data = new HomeDataEntities2();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            var listHouse = data.Houses.Take(9).ToList();
            return View(listHouse);
        }

        public ActionResult ProductDetail(int houseId = 1)
        {
            House houseDetails = data.Houses.FirstOrDefault(house => house.HouseId == houseId);
            if (houseDetails == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(houseDetails);

        }
    }
}