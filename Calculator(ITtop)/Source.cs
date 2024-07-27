using System;
using System.Data;

namespace Calculator_ITtop_
{
    internal class Source
    {
        public static string Evaluate(string expression)
        {
            try
            {
                var result = new DataTable().Compute(expression, null);
                return result.ToString();
            }
            catch (Exception)
            {
                return "Error";
            }
        }
    }
}
