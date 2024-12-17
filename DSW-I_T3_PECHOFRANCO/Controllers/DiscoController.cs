using DSW_I_T3_PECHOFRANCO.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSW_I_T3_PECHOFRANCO.Controllers
{
    public class DiscoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiscoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Listado de Discos
        public IActionResult Index()
        {
            var discos = _context.Discos.ToList();
            return View(discos);
        }

        // Crear Disco (GET)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Guardar Disco (POST)
        [HttpPost]
        public IActionResult Create(Disco disco)
        {
            if (ModelState.IsValid)
            {
                _context.Discos.Add(disco);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disco);
        }

        // Editar Disco (GET)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var disco = _context.Discos.Find(id);
            if (disco == null) return NotFound();

            return View(disco);
        }

        // Actualizar Disco (POST)
        [HttpPost]
        public IActionResult Edit(Disco disco)
        {
            if (ModelState.IsValid)
            {
                _context.Discos.Update(disco);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disco);
        }

        // Eliminar Disco
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var disco = _context.Discos.Find(id);
            if (disco != null)
            {
                _context.Discos.Remove(disco);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
