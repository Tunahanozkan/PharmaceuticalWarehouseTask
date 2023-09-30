using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
    public class EfStockDal : GenericRepository<Stock>, IStockDal
    {
        private readonly PharmacyContext _context;
        public EfStockDal(PharmacyContext context) : base(context)
        {
        }
        public List<Stock> GetAllStocksWithMedicine()
        {
            return _context.Stocks.Include(s => s.Medicine).ToList();
        }
    }
}
