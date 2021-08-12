﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;


namespace ASP_Dot_Net_MVC_Aug_2021.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepo _vendorRepo;

        public VendorController(IVendorRepo vendorRepo)
        {
            _vendorRepo = vendorRepo;
        }
        public IActionResult Index()
        {
            return View(_vendorRepo.GetAllVendors());
        }
    }
}