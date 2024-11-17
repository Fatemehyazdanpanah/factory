using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.operation
{
     class simpleprime : calculator

    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("simpleprime");

            bool check = true;

            {
                for (int i = 2; (check && i < number); i++)
                    if (number % i == 0)
                        check = false;
            }

            return check;
        }
    }
}
