using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_assesment_one_2
{
    public class Analyse
    {
        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text

        
        //private variables - encapulation 
        private int vowels = 0;
        private int consonants= 0;
        private int uppercase = 0;
        private int lowercase = 0;
        private int sentances = 0;

        //List of integers to hold the first five measurements:
        //1. Number of sentences
        //2. Number of vowels
        //3. Number of consonants
        //4. Number of upper case letters
        //5. Number of lower case letters

        public static List<int> values = new List<int>();

        public List<int> analyseText(string input)
        {

            //creates variable for the length of the innputed sentances 
            int length = input.Length;
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            //goes through every letter inpuuted 
            for(int i =0; i < input.Length; i++)
            {
                //cheacking if the letter if a vowel - both uppercase and lowercase 
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    //adds one to the vowels variable 
                    vowels = vowels + 1;
                }
                
                //cheacking if the letter is constantant - both uppercase and lowercase
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    //adds one to the consonants variable
                    consonants = consonants + 1;
                }

                //checking if the letter is uppercase 
                if (char.IsUpper(input[i]))
                {
                    //adds one to the uppercase variable 
                    uppercase = uppercase + 1;
                }

                //checking if the letter is lower case 
                if(char.IsLower(input[i]))
                {
                    //adds one to the lower case variable 
                    lowercase = lowercase + 1;
                }

                //cheacks if it is a . meaning the end of a sentance 
                if(input[i] == '.')
                {
                    //adds one to the sentance variable 
                    sentances = sentances + 1;
                }

            }

            //adds all the sentance, vowels, constants, uppercase and lowercase variables to the values list 
            values.Insert(0, sentances);
            values.Insert(1, vowels);
            values.Insert(2, consonants);
            values.Insert(3, uppercase);
            values.Insert(4, lowercase);

            //creates an instance of the report class 
            Report Output = new Report();
            Output.Output(Analyse.values);





            return values;
        }
    }
}

