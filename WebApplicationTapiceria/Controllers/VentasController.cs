using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTapiceria.Models;

namespace WebApplicationTapiceria.Controllers
{
    public class VentasController : Controller
    {
        // GET: Ventas
        [HttpGet]public ActionResult CalculoVenta()
        {
            return View(new Venta());
        }

        [HttpPost] public ActionResult CalculoVenta(Venta reg)
        {
            ViewBag.descuento = reg.Descuento();
            ViewBag.neto = reg.Total();




            return View();
        }
    }
}