using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stock
    {
        public int StockId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
