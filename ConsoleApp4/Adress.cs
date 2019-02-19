using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Adress
    {
        public int Id { get; set; }
        public int Country { get; set; }
        public virtual Building Buildings { get; set; }
        public virtual ICollection <Producer> Producers { get; set; }
    }
}
