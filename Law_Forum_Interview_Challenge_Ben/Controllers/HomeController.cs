using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Law_Forum_Interview_Challenge_Ben.Models;

namespace Law_Forum_Interview_Challenge_Ben.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(GridViewModel.GridBuilderType builderType, int NumRows, int NumDivisibleBy, int NumLower, int NumUpper)
        {
            IGridBuilder builder;

            switch (builderType)
            {
                default:
                    builder = new LoopingGridBuilder();
                    break;
            }

            var vm = new GridViewModel
            {
                BuilderType = builderType,
                Grid = builder.CreateGrid(NumRows, NumDivisibleBy, NumLower, NumUpper),
                NumRows = NumRows,
                NumDivisibleBy = NumDivisibleBy,
                NumLower = NumLower,
                NumUpper = NumUpper

            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
