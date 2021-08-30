using Microsoft.AspNetCore.Mvc;
using semana4.Models;
using semana4.Data;
using System.Linq;

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
            return View(_context.DataVideojuegos.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Videojuegos objVideojuegos)
        {
            _context.Add(objVideojuegos);
            _context.SaveChanges();
            ViewData["Message"] = "El videojuego ya esta registrado";
            return View();
        }
        public IActionResult Edit(int id)
        {
            Videojuegos objVideojuegos = _context.DataVideojuegos.Find(id);
            if(objVideojuegos == null){
                return NotFound();
            }
            return View(objVideojuegos);
        }
        [HttpPost]
        public IActionResult Edit(int id,[Bind("Id,Nombre,Categoria,Precio,Descuento")] Videojuegos objVideojuegos)
        {
             _context.Update(objVideojuegos);
             _context.SaveChanges();
              ViewData["Message"] = "El videojuego ya esta actualizado";
             return View(objVideojuegos);
        }

        public IActionResult Delete(int id)
        {
            Videojuegos objVideojuegos = _context.DataVideojuegos.Find(id);
            _context.DataVideojuegos.Remove(objVideojuegos);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}