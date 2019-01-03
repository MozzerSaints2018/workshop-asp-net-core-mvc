using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMvc.Models;

namespace SaleWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Deparment> list = new List<Deparment>();

            list.Add(new Deparment { Id = 1, Name = "Eletronics" });
            list.Add(new Deparment { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}