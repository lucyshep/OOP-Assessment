using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_assesment_one_2
{
    public class Input
    {
         
        //Handles the text input for Assessment 1.
        string text;

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            //outputs asking the user for a input 
            Console.WriteLine("please enter the sentance you would like to anaylse, ending the sentance in *");
            //takes the input 
            string input = Console.ReadLine();

            //creats instance of the analyse class 
            Analyse analysis = new Analyse();
            analysis.analyseText(input);

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput(string file)
        {

            string text = System.IO.File.ReadAllText(file);
            
            //creates instance of the anysis class
            Analyse analysis = new Analyse();
            analysis.analyseText(text);

            //creates instance of the long words class 
            LongWords words = new LongWords();
            words.LongWord(text);


            return text;


        }

    }
}
