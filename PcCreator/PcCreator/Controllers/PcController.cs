using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PcCreator.Models;
using PcCreator.Models.PcCreator;

namespace PcCreator.Controllers
{
    [Authorize(Roles = "admin")]
    public class PcController : Controller
    {
        private readonly IPcService _pcService;

        public PcController(IPcService pcService)
        {
            _pcService = pcService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_pcService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Pc model = new Pc();
            model.Cpus = _pcService
                .FindAllCpusForViewModel()
                .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.Name })
                .ToList();

            model.Gpus = _pcService
                .FindAllGpusForViewModel()
                .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.FullName })
                .ToList();

            return View(model);
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
                pc.Cpus = _pcService
                    .FindAllCpusForViewModel()
                    .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.Name })
                    .ToList();

                pc.Gpus = _pcService
                    .FindAllGpusForViewModel()
                    .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.FullName })
                    .ToList();

                SetValidationClasses();
                // Przekazanie słownika z błędami do widoku
                return View(pc);
            }
        }

        [HttpGet]
        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateApi(Pc pc)
        {
            if (ModelState.IsValid)
            {
                _pcService.Add(pc);
                return RedirectToAction("Index");
            }

            SetValidationClasses();
            Console.WriteLine("Błąd walidacji");
            return View(pc);
        }

        public IActionResult Details(int id)
        {
            var pc = _pcService.FindById(id);
            var viewModel = new PcDetailsViewModel
            {
                Pc = _pcService.FindById(id),
                Cpu = _pcService.FindCpuById(pc.CpuId),
                Gpu = _pcService.FindGpuById(pc.GpuId)
            };

            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            _pcService.Delete(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _pcService.FindById(id);
            model.Cpus = _pcService
                .FindAllCpusForViewModel()
                .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.Name })
                .ToList();

            model.Gpus = _pcService
                .FindAllGpusForViewModel()
                .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.FullName })
                .ToList();

            return View(model);
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
                pc.Cpus = _pcService
                    .FindAllCpusForViewModel()
                    .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.Name })
                    .ToList();

                pc.Gpus = _pcService
                    .FindAllGpusForViewModel()
                    .Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.FullName })
                    .ToList();

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
