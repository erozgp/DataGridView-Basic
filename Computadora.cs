using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    internal class Computadora
    {
        public string Name { get; set; }
        public int Launched { get; set; }
        public string Sku { get; set; }
        public string Memory { get; set; }
        public string Processor { get; set; }

        public Computadora(string name, int launched, string sku, string memory, string processor)
        {
            Name = name;
            Launched = launched;
            Sku = sku;
            Memory = memory;
            Processor = processor;
        }
    }
}
