using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression.Classes
{
    public class RegressionMethod
    {
        private int _age;
        private double _weight;
        private double _neck;
        private double _abdomen;
        private double _thigh;
        private double _forearm;
        private double _wrist;
        
        public RegressionMethod(int age, double weight, double neck, double abdomen, double thigh, double forearm, double wrist)
        {
            _age = age;
            _weight = weight;
            _neck = neck;
            _abdomen = abdomen;
            _thigh = thigh;
            _forearm = forearm;
            _wrist = wrist;
        }

        public double CalculateRegression()
        {
            double regression = 0;
            regression = -33.25799117 +( (0.068165796 * _age) + (-0.119440533 * _weight) + (-0.403802076 * _neck) + (0.917884996 * _abdomen) 
                            + (0.221959759 * _thigh) + (0.55313935 * _forearm) + (-1.532401078 * _wrist));
            
            return regression;
        }
    }
}
