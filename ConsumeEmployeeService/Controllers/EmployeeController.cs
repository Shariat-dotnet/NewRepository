﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumeEmployeeService.ServiceReference1;

namespace ConsumeEmployeeService.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepositoryClient client=new EmployeeRepositoryClient();
        // GET: Employee
        public ActionResult Index()
        {
           var data= client.GetEmployees();
            return View(data);
        }

        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}