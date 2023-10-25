using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab7_calc.MyCalculator
{
    public class Calculator
    {
       

        public double Sum(string x, string y)
        {
            double newX, newY;
            try
            {
                newX = Convert.ToDouble(x);
                newY = Convert.ToDouble(y);
                return newX + newY;
            }
            catch 
            {
                throw new Exception("invalid operators");
            }
            
        }

        public double Res(string x, string y)
        {
            double newX, newY;
            try
            {
                newX = Convert.ToDouble(x);
                newY = Convert.ToDouble(y);
                return newX - newY;
            }
            catch
            {
                throw new Exception("invalid operators");
            }
        }

        public double Mul(string x, string y)
        {
            double newX, newY;
            try
            {
                newX = Convert.ToDouble(x);
                newY = Convert.ToDouble(y);
                return newX * newY;
            }
            catch
            {
                throw new Exception("invalid operators");
            }
        }

        public double Div(string x, string y)
        {
            double newX, newY;
            try
            {
                newX = Convert.ToDouble(x);
                newY = Convert.ToDouble(y);
                return newX / newY;
            }
            catch
            {
                throw new Exception("invalid operators");
            }
        }

        
    }
}
