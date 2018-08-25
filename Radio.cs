using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class Radio
    {
        public void TurnOn (bool on){
            if (on)
                Console.WriteLine("Jamming....");
            Console.WriteLine("Quiet time....");
        }
    }
}
