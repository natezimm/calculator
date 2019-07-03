using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string textInput){
            double convertedNumber;
            if (!double.TryParse(textInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");
            return convertedNumber;
        }
    }
}
