using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Data;

namespace Cars.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Context())
            {
                var result = c.Manufacturers.Where(m => m.Name.StartsWith("A")).ToList();

            }
        }
    }
}
