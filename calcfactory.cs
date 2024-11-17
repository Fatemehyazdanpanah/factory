

using System.ComponentModel.Design;

namespace ConsoleApp21.operation
{
     static class calcfactory
    { 
        public static calculator Factory(uint number)
        { 
        calculator calc;


            if (number <= 1000)
                calc = new simpleprime();
            else if (number <= 2000)
                calc = new proprime();
            else if (number <= 3000)
                calc = new decision_tree();
            else
                calc = new palindrome();
            

            return calc;
        }
    }

}

