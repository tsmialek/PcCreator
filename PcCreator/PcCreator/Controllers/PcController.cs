using Microsoft.AspNetCore.Mvc;
using PcCreator.Models;

namespace PcCreator.Controllers
{
    public class PcController : Controller
    {
        private readonly IPcService _pcService;

        public PcController(IPcService pcService)
        {
            _pcService = pcService;
        }

        public IActionResult Index()
        {
            return View(_pcService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pc pc)
        {
            if (ModelState.IsValid)
            {
                _pcService.Add(pc);
                return RedirectToAction("Index");
            }
            else
            {
                SetValidationClasses();
                // Przekazanie słownika z błędami do widoku
                return View(pc);   
            }
        }

        public IActionResult Details(int id)
        {
            return View(_pcService.FindById(id));
        }

        public IActionResult Delete(int id)
        {
            _pcService.Delete(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_pcService.FindById(id));
        }

        [HttpPost]
        public IActionResult Edit(Pc pc)
        {
            if (ModelState.IsValid)
            {
                _pcService.Update(pc);
                return RedirectToAction("Index");
            }
            else
            {
                SetValidationClasses();

                // Zwróć ten sam widok z aktualnym modelem do poprawy
                return View(pc);
            }
        }

        private void SetValidationClasses()
        {
            foreach (var key in ModelState.Keys)
            {
                // Ustaw klasę na 'is-invalid' lub 'is-valid' w zależności od stanu walidacji pola
                var errorCount = ModelState[key].Errors.Count;
                ViewData[key + "Class"] = errorCount > 0 ? "is-invalid" : "is-valid";
            }
        }
    }
}
