

namespace ConsoleApp21.operation
{
    class decision_tree : calculator
    {
        public override bool IsTrue(uint number)
        {






            string userInput = number.ToString();



            Console.WriteLine("Is your favorite sport played indoors or outdoors? (1: indoors, 2: outdoors)");
            int input1 = int.Parse(Console.ReadLine());

            string result = "";


            if (input1 == 1)
            {

                Console.WriteLine("Is it a team-based sport? (1: yes, 2: no)");
                int input2 = int.Parse(Console.ReadLine());

                if (input2 == 1)
                {

                    Console.WriteLine("Does your favorite sport use a ball? (1: yes, 2: no)");
                    int input3 = int.Parse(Console.ReadLine());

                    if (input3 == 1)
                    {
                        result = "Your favorite indoor sport is Basketball or Volleyball!";
                    }
                    else
                    {
                        result = "Your favorite indoor sport might be something like Gymnastics or Table Tennis.";
                    }
                }
                else
                {

                    Console.WriteLine("Your favorite indoor sport might be Gymnastics or Table Tennis.");
                }
            }
            else if (input1 == 2)
            {

                Console.WriteLine("Is it a team-based sport? (1: yes, 2: no)");
                int input2 = int.Parse(Console.ReadLine());

                if (input2 == 1)
                {

                    result = "Your favorite outdoor sport is Football or Rugby!";
                }
                else
                {

                    Console.WriteLine("Does your favorite sport use a ball? (1: yes, 2: no)");
                    int input3 = int.Parse(Console.ReadLine());

                    if (input3 == 1)
                    {
                        result = "Your favorite outdoor sport is Tennis!";
                    }
                    else
                    {
                        result = "Your favorite outdoor sport might be Running or Hiking.";
                    }
                }
            }
            else
            {

                Console.WriteLine("Invalid input! Please enter 1 for indoors or 2 for outdoors.");
                return false;
            }

            Console.WriteLine(result);
            return true;
        }
    }

            return base.IsTrue(number);
}

        
