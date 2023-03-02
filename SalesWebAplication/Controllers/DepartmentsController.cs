using Microsoft.AspNetCore.Mvc;
using System;
using SalesWebAplication.Models;
using System.Collections.Generic;

namespace SalesWebAplication.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos"});
            list.Add(new Department { Id = 2, Name = "Ferramentas" });

            return View(list);
        }
    }
}
