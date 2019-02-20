using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool JsLegal { get; set; }
        public virtual ICollection<AbstractProduct> AbstractProducts { get; set; }
    }
}
