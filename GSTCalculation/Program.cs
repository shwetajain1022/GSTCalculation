using GSTCalculation.Services;
using System;

namespace GSTCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                Console.WriteLine("Please enter amount (GST inclusive) for which GST is calculated : ");
                double gstInclusiveAmount = 0;
                if (double.TryParse(Console.ReadLine(), out gstInclusiveAmount))
                {
                    IGSTCalculator gstCalculator = new GSTCalculator(gstInclusiveAmount);
                    gstCalculator.CalculateGSTAmount();
                    Console.WriteLine($@" Net Amount :{gstCalculator.NetAmount} \n 
                                      GST Amount :{gstCalculator.GSTAmount} \n 
                                      GST Rate :{gstCalculator.GSTRatePercent} \n
                                      for GST Inclusive Amount of {gstCalculator.GrossAmount}");
                }
                else
                {
                   Console.WriteLine("Please enter a numeric value for the gst calculation. ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error occured while doing the calculation : {ex.Message}");
            }
        }
    }
}
