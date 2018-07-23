using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteRepository = new Repository();
            var bandController = new BandController(concreteRepository);
        }
    }
}
