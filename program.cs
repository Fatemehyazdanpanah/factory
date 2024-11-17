using ConsoleApp21.operation;
uint number =  Convert.ToUInt32( Console.ReadLine());
calculator calc = calcfactory.Factory(number);

Console.WriteLine(calc.IsTrue(number));

