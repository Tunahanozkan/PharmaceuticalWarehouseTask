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
    public class MedicineManager : IMedicineService
    {
        private readonly IMedicineDal _medicineDal;

        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }

        public void Delete(Medicine entity)
        {
            _medicineDal.Delete(entity);
        }

        public List<Medicine> GetAll()
        {
            return _medicineDal.GetAll();
        }

        public Medicine GetById(int id)
        {
            return _medicineDal.GetById(id);
        }

        public void Insert(Medicine entity)
        {
            _medicineDal.Insert(entity);
        }

        public void Update(Medicine entity)
        {
            _medicineDal.Update(entity);
        }
    }
}
