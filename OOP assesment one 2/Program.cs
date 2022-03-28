using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_assesment_one_2
{
    class Program
    {
        
       
        static void Main()
        {
            bool valid = false;
            bool valid2 = false;

            //sets the file directory. 
            string file;

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file

            

            while(valid2 == false)
            {
                //asks the user how what they would like to anayse 
                Console.WriteLine("1. Do you want to enter the text via the keyboard?");
                Console.WriteLine("2. Do you want to read in the text from a file?");
                string UserInput = Console.ReadLine();

                //is user input is equal to one 
                if (UserInput == "1")
                {
                    //creates instance of the input class to the manualtextfunction
                    Input checker = new Input();
                    checker.manualTextInput();
                    valid2 = true;

                }

                //else if the user input is 2 
                else if (UserInput == "2")
                {
                    //while loop for error checking 
                    while (valid == false)
                    {
                        //takes user input of file directory 
                        Console.WriteLine("please enter the directory of the file you would like to use");
                        file = Console.ReadLine();
                        //try catch statement to make sure the user entered a valid input 
                        try
                        {
                            //creates new intance of the input class to the filetextinput function
                            Input checker = new Input();
                            checker.FileTextInput(file);
                            valid = true;
                            valid2 = true;
                        }
                        //if incorrect then outputs saying invalid input
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("file not found, please try again");
                        }


                    }
                }
                else
                {
                    //tells the user that it was an invalid input
                    Console.WriteLine("invalid input");
                }

                    

                

               

            }
            
              

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            //Report the results of the analysis
            //TO ADD: Get the frequency of individual letters?


         }


        


        
    }


  
}

