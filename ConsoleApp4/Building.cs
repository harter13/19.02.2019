using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Building
    {
        public int Id { get; set; }
        public int Numbers { get; set; }
        public string Letters { get; set; }
        public virtual ICollection <Adress> Adresses { get; set; }
    }
}
