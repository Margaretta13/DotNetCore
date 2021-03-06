﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyPieShop.Models;
using BethanyPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanyPieShop.Controllers
{
    public class PieController : Controller
    {
        private IPieRepository _pieRepository;
        private ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }

        public ViewResult List()
        {
            var pieListVm = new PieListViewModel();

            pieListVm.Pies = _pieRepository.Pies;
            pieListVm.CurrentCategory = "Cheese Cake";
            return View(pieListVm);
        }
       
    }
}
