using eMovieTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var response =_context.Actors.ToList();
            return View(response);
        }

        [HttpPost]
        public IActionResult Index(int val)
        {
            var response = _context.Actors.ToList();
            return View(response);
        }
    }
}
