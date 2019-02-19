using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
   public class Order
   {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection <RealProduct> RealProducts { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
   }
}
