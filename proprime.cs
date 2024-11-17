namespace ConsoleApp21.operation
{
    class proprime : calculator
    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("proprime");
            bool check = true;

            {
                for (int i = 2; (check && i < Math.Sqrt(number)); i++)
                    if (number % i == 0)
                        check = false;
            }

            return check;
        }
    }
}

