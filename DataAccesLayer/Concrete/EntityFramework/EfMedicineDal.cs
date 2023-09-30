using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Context;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
    public class EfMedicineDal : GenericRepository<Medicine>, IMedicineDal
    {
        public EfMedicineDal(PharmacyContext context) : base(context)
        {
        }
    }
}
