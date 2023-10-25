using lab7_calc.MyCalculator;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab7_calc
{
    public class Program
    {

        static void Main(string[] args)
        {
            string bufer;
            string[] operators;
            string result = null;
            ConsoleKeyInfo key;
            key = Console.ReadKey();
          
            do
            {
                Console.Clear();
                
                while (true)
                {
                    bufer = Console.ReadLine();
                    if(bufer.Contains('+'))
                    {
                        operators = bufer.Split('+');

                        result= Sum(operators[0], operators[1], result);
                        Console.WriteLine(result);
      
                        operators = null;
                    }
                    else if (bufer.Contains('-'))
                    {
                        operators = bufer.Split('-');
                        result = Res(operators[0], operators[1], result);
                        Console.WriteLine(result);

                        operators = null;
                    }
                    else if (bufer.Contains('*'))
                    {
                        operators = bufer.Split('*');
                        result = Mul(operators[0], operators[1], result);
                        Console.WriteLine(result);

                        operators = null;
                    }
                   else if (bufer.Contains('/'))
                    {
                        operators = bufer.Split('/');
                        result = Div(operators[0], operators[1], result); 
                        Console.WriteLine(result);

                        operators = null;
                    }
                    else if (bufer == "")
                    {
                        result = "";
                        break;
           
                    }
                    else
                    {
                        result = "";
                        break;
                    }
                }
                
            }
            while (true);
        }

        public static string Sum(string x, string y, string result)
        {
            Calculator calculator = new Calculator();
            if (x == "")
            {
                try
                {
                    result = calculator.Sum(result,y ).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else
            {
                try
                {
                    result = calculator.Sum(x, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            return result;
        }

        public static string Res(string x, string y, string result)
        {
            Calculator calculator = new Calculator();
            if (x == "")
            {
                try
                {
                    result = calculator.Res(result, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else
            {
                try
                {
                    result = calculator.Res(x, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            return result;
        }

        public static string Mul(string x, string y, string result)
        {
            Calculator calculator = new Calculator();
            if (x == "")
            {
                try
                {
                    result = calculator.Mul(result, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else
            {
                try
                {
                    result = calculator.Mul(x, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            return result;
        }

        public static string Div(string x, string y, string result)
        { 
            Calculator calculator = new Calculator();
            if (x == "")
            {
                try
                {
                    result = calculator.Div(result, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            else
            {
                try
                {
                    result = calculator.Div(x, y).ToString();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            return result;
        }
    }
}
