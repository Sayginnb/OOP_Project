﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OOP_Project.Models;

namespace OOP_Project.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceService.Insert(new Service()
                {
                    Title = model.Title,
                    Image= model.Image,
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult DeleteService(int id)
        {
           var values = _serviceService.GetById(id);
            _serviceService.Delete(values);
            return RedirectToAction("Index");
        }
    }
}