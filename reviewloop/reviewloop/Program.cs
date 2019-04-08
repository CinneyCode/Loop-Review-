using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewloop
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List <string> names = new List<string> () { "Tom", "Matt", "Michelle", "Trible"};
            bool isFound = false;
            int i = 0;
            do
            {
                if (names[i] == "Michelle")
                {
                    isFound = true;
                }
                i++; //you have to include this because it's a loop 
            } while (!isFound && i < names.Count);
            //loop for total 

            List <decimal> salaries = new List<decimal> () { 25000m, 35000m, 45000m};
            decimal total = 0m;
            for (int j = 0; j < salaries.Count; j++)
              
            {
                total += (salaries[j] * 0.075m);
            }

            Console.WriteLine($"total = {total:f2}");
            //same thing , second verse
            decimal sum = 0m;
            foreach ( decimal s in salaries)
            {
                sum += s * 0.07m;
            }
            Console.WriteLine($"Sum = {sum:C}");
            //try catch will try us error and crashing (will not be on the exam) 

            decimal taxAmt = CalcTax(salaries);
            List<decimal> salesAmt = new List<decimal>() { 3.40m, 5.50m }; //declaring it in a list 
            decimal salesTax = CalcTax(salesAmt); //whatever gets return in a sum will goes inside salesTax 



            Console.ReadKey();
        }
        //method 
        static private decimal CalcTax ( List <decimal> sals) //sals for salarey . sals have three items in it 
        {
            decimal sum = 0m;
            foreach (decimal s in sals)
            {
                sum += s * 0.07m;
            }

            return sum; 
        } //do one thing on method , just one function 
         // create a single method that everyone can use . don't put alot of function on one thing. it's gonna get crazy 
         // just return one fuction, wether it's printing output, calulating sal, 



    }
}
