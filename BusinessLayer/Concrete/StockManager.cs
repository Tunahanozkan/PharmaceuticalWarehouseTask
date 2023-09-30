using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public void Delete(Stock entity)
        {
            _stockDal.Delete(entity);
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetAll();
        }

        public List<Stock> GetAllStocksWithMedicine()
        {
            return _stockDal.GetAllStocksWithMedicine();
        }

        public Stock GetById(int id)
        {
            return _stockDal.GetById(id);
        }

        public void Insert(Stock entity)
        {
            _stockDal.Insert(entity);
        }

        public void Update(Stock entity)
        {
           _stockDal.Update(entity);
        }
    }
}
