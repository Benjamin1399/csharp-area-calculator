using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorApp.Models
{
    /*
     * Square has equal sides so just need one prop for length
     */
    public class SquareModel : IAreaCalculator
    {
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Length * Length;
        }
    }
}
