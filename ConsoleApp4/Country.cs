using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection <Adress> Adresses { get; set; }
    }
}
