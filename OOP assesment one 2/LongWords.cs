using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace OOP_assesment_one_2
{
    class LongWords
    {
        public void LongWord(string text)
        {
            //creates list to add each word to. 
            string[] words = text.Split(' ');
            //creates list of the long words 
            List<string> Long = new List<string>();

            //goes through each element of the list of the words 
            for (int i = 0; i < words.Length; i++)
            {
                //checks if the word is greater then 7 letters long 
                if (words[i].Length >= 7)
                {
                    //adds it to the list of long words
                    Long.Add(words[i]);
                }
            }

            //sets the file path to where the code is saved 
            string path = @"MyTest.txt";

            // Create a file to write to
            using (StreamWriter sw = File.CreateText(path))
            {
                //goes through the long word list 
                for (int i = 0; i < Long.Count; i++)
                {
                    //writes all the ele
                    sw.WriteLine(Long[i]);
                }
            }



        }




    }
}
