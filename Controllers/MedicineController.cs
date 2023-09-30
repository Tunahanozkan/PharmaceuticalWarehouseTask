using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PharmaceuticalWarehouse.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService mediicineService)
        {
            _medicineService = mediicineService;
        }

        public IActionResult Index()
        {
            var values = _medicineService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddMedicine()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMedicine(Medicine medicine)
        {
            _medicineService.Insert(medicine);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMedicine(int id)
        {
            var value = _medicineService.GetById(id);
            _medicineService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateMedicine(int id)
        {
            var value = _medicineService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateMedicine(Medicine medicine)
        {
            _medicineService.Update(medicine);
            return RedirectToAction("Index");
        }
        public ActionResult MedicineDetails(int id)
        {
            var value = _medicineService.GetById(id);
            return View(value);
        }
    }
}
