﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EatWise.Data;
using EatWise.Models;

namespace EatWise.Controllers
{
    public class NutricionistasController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }       
    }
}
