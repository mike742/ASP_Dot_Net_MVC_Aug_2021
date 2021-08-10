﻿using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemRepo _repository;

        public ItemsController(IItemRepo repository)
        {
            _repository = repository;
        }

        // GET: ItemsController
        public ActionResult Index()
        {
            return View(_repository.GetAllItems());
        }

        // GET: ItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.GetItemById(id));
        }

        // GET: ItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Item newItem)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
