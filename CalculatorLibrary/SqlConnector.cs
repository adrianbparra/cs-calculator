using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreateCalculation method to actually save to database
        /// <summary>
        /// Saves the calculation to the database
        /// </summary>
        public CalculatorModel CreateCalculation(CalculatorModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
