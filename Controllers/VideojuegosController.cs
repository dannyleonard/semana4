using Microsoft.AspNetCore.Mvc;
using semana4.Models;
using semana4.Data;
namespace semana4.Controllers
{
    public class VideojuegosController: Controller
    {
        private readonly ApplicationDbContext _context;

        public VideojuegosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Videojuegos objVideojuegos)
        {
            _context.Add(objVideojuegos);
            _context.SaveChanges();
            ViewData["Message"] = "El videojuego ya esta registrado";
            return View("Index");
        }
    }
}