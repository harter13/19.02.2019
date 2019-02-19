using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class RealProduct
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public virtual AbstractProduct AbstractProduct { get; set; }
        public virtual Producer Producer { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiresDate { get; set; }
        public int Quantity { get; set; }

    }
}
