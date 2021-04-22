using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class TextConnection : IDataConnection
    {
        //TODO - Create CreateCalculation method for text connection

        /// <summary>
        /// Connection for calculation model
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public CalculatorModel CreateCalculation(CalculatorModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
