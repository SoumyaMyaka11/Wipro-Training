﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
