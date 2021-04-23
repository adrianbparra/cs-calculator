using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculatorModel
    {
        /// <summary>
        /// The unique identifier for the calculation
        /// </summary>
        public int Id { get; set; }

        public int answer { get; set; }

        public string calculation { get; set; }

    }
}
