using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assesment_one_2
{
    class Report
    {
        //Handles the reporting of the analysis.
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void Output(List<int> values)
        {
            //outputs each varibale which is stored in the list 
            Console.WriteLine("number of vowels entered = " + values[1]);
            Console.WriteLine("number of consonants entered =" + values[2]);
            Console.WriteLine("number of uppercases letters entered = " + values[3]);
            Console.WriteLine("number of lowercase letters entered = " + values[4]);
            Console.WriteLine("number of sentances entered = " + values[0]);
        }
        

    }
}

