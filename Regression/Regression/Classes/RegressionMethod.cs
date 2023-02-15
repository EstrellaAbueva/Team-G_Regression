using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression.Classes
{
    public class RegressionMethod
    {
       
        public double CalculateRegression(int age, double weight, double neck, double abdomen, double thigh, double forearm, double wrist)
        {
            double regression = -33.25799117 + ( (0.068165796 * age) + (-0.119440533 * weight) + (-0.403802076 * neck) + (0.917884996 * abdomen) 
                            + (0.221959759 * thigh) + (0.55313935 * forearm) + (-1.532401078 * wrist));
            
            return regression;
        }
    }
}
