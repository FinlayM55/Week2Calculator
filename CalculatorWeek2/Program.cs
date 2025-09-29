CalculatorApp();

void CalculatorApp()
{
    int FirstNumber = 0;
    int SecondNumber = 0;
    int Result = 0;
   

    Console.WriteLine("Type in the First Number");
    FirstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type in the Second Number");
    SecondNumber = Convert.ToInt32(Console.ReadLine());

    Result = FirstNumber + SecondNumber;

    Result = FirstNumber + SecondNumber;
    Console.WriteLine("Adding {0} and {1} equals {2}", FirstNumber, SecondNumber, Result);
}

// 123