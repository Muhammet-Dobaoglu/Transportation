using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class StatisticController : Controller
    {
        DbTransportEntities2 db = new DbTransportEntities2 ();
        public ActionResult Index()
        {
            ViewBag.customerCount = db.TblCustomer.Count();
            
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").Count();
            
            ViewBag.categoryCount = db.TblCategory.Count();
            
            //ViewBag.citySelect = db.TblCustomer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity);
            
            ViewBag.employeeName = db.TblEmployee.Where(x => x.EmployeeID == 1).Select(y => y.EmployeeName).SingleOrDefault();
            
            ViewBag.urunSayısı = db.TblProduct.Count();
            
            ViewBag.cityName = db.TblCustomer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity).SingleOrDefault();
            
            return View();
        }
    }
}
