using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOrder
{
    class MainChoice
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {(this.Price != 0 ? this.Price.ToString("C") : "")}";
        }
    }
}
