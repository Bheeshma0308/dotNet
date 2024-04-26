using Microsoft.AspNetCore.Mvc;
using studentdetails.DAL;
using studentdetails.Models;
using studentdetails.Models.DBEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentdetails.Controllers
{
    public class StudentController : Controller
    {
        private readonly studentDbContext _context;

        public StudentController(studentDbContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var student = _context.students.ToList();
            List<Studentviewmodel> studentsList = new List<Studentviewmodel>();

            if (student != null)
            {
                foreach(var studen in student)
                {
                    var Studentviewmodel = new Studentviewmodel()
                    {
                        Id = studen.Id,
                        FName = studen.FName,
                        LName =  studen.LName,
                        DOB = studen.DOB,
                        address = studen.address
                    };
                    studentsList.Add(Studentviewmodel);
                }
                return View(studentsList);
            }
            return View(studentsList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Studentviewmodel studentdata)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var std = new Student()
                    {
                        Id = studentdata.Id,
                        FName = studentdata.FName,
                        LName = studentdata.LName,
                        DOB = studentdata.DOB,
                        address = studentdata.address
                    };
                    _context.students.Add(std);
                    _context.SaveChanges();
                    TempData["successMessage"] = "student data created successfully.";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }
    }
}
