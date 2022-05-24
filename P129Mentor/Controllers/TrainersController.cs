using Microsoft.AspNetCore.Mvc;
using P129Mentor.DAL;
using P129Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P129Mentor.Controllers
{
    public class TrainersController : Controller
    {

        private readonly AppDbContext _context;

            public TrainersController(AppDbContext context)
            {
                 _context = context;
            }
        public IActionResult Index()
        {

            List<Trainer> trainers = _context.Trainers.ToList();
            return View(trainers);
        }
    }
}
