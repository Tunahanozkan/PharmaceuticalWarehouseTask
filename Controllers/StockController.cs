using BusinessLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PharmaceuticalWarehouse.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockService _stockService;
        private readonly PharmacyContext _harmacyContext;

        public StockController(IStockService stockService, PharmacyContext harmacyContext)
        {
            _stockService = stockService;
            _harmacyContext = harmacyContext;
        }

        public async Task<IActionResult> Index()
        {
            var stocks = _harmacyContext.Stocks
           .Include(s => s.Medicine)
           .ToList();

            return View(stocks);
        }

        [HttpGet]
        public IActionResult AddStock()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStock(Stock stock)
        {
            _stockService.Insert(stock);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteStock(int id)
        {
            var value = _stockService.GetById(id);
            _stockService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateStock(int id)
        {
            var stock = await _harmacyContext.Stocks
                .Include(s => s.Medicine)
                .FirstOrDefaultAsync(s => s.StockId == id);  
            return View(stock);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStock(Stock stock)
        {
            if (ModelState.IsValid)
            {
                    _harmacyContext.Update(stock);
                    await _harmacyContext.SaveChangesAsync();            
                return RedirectToAction(nameof(Index));
            }
            return View(stock);
        }
    }
}
