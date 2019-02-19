using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  Adress Adress { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
