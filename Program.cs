using System;
// McCloskey, Spencer ISM 4300 February 9, 2022
namespace MCCLOSKEY___T_3___Using_Iterative_Statements
{
    class Program
    {
        public static void Main()
        {
            // int variable for CAD
            int inc_value;

            // input between 5 and 25
            // with input validation if, input value is outside 5-25
            while (true)
            {
                // input
                Console.Write("Enter increment value between 5 and 25:");
                inc_value = Convert.ToInt32(Console.ReadLine());
                // check if between 5 and 25
                if (inc_value >= 5 && inc_value <= 25)
                {
                    break;
                }
                // if not,ask once more
                Console.WriteLine("Increment value must be between 5 and 25. Please try again.");
            }

            // variable for CAD and USD
            double CAD = 0, USD;

            // headers
            Console.WriteLine("CAD   US$");
            Console.WriteLine("-------------");

            // do-while loop
            do
            {
                // calculate USD for CAD
                // multiply 0.792367 
                USD = CAD * 0.792367;
                // print 
                Console.WriteLine(CAD + "    " + USD);

                // increment CAD by inc_value
                CAD += inc_value;
            }
            //while, conditiom
            while (CAD <= 200);
        }
    }
}
