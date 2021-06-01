using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTCalculation.Services
{
    public interface IGSTCalculator
    {
        double NetAmount { get; set; }
        double GrossAmount { get; set; }
        double GSTAmount { get; set; }
        double GSTRatePercent { get; set; }
        bool GSTInclusive { get; set; }
        void CalculateGSTAmount();
    }
}
