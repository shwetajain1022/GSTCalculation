using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTCalculation.Services
{
    public class GSTCalculator : IGSTCalculator
    {
        public GSTCalculator(double grossAmount, double gstRate = 10, bool gstInclusive = true)
        {
            GrossAmount = grossAmount;
            GSTRatePercent = gstRate;
            GSTInclusive = gstInclusive;
        }
        public double NetAmount { get; set ; }
        public double GrossAmount { get ; set ; }
        public double GSTAmount { get; set ; }
        public double GSTRatePercent { get; set; }
        public bool GSTInclusive { get; set; }
        public void CalculateGSTAmount()
        {
            if(GSTInclusive)
            {
                NetAmount =Math.Round(GrossAmount / (1 + (GSTRatePercent / 100)),2);
                GSTAmount = GrossAmount - NetAmount;
            }
            else
            {
                NetAmount = Math.Round(GrossAmount * (1 + (GSTRatePercent / 100)),2);
                GSTAmount = GrossAmount - NetAmount;
            }
        }
    }
}
