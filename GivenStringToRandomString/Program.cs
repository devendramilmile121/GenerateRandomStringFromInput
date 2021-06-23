using System;
using System.Linq;

namespace GivenStringToRandomString
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            string input = "are you happy";
            
            // split the user input to get the words
            string[] split_Input = input.Split(" ");
            
            // initilize the output variable
            string output = string.Empty;

            /*
             Looping throug the split_input array to match the word and do shuffling
             of Characters in the array
             */
            for (int i = 0; i < split_Input.Length; i++)
            {
                // create new guid and get order it randomly
                char[] arryOfInput = split_Input[i].ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray();

                // generate the random word
                if (i==0)
                {
                    output += string.Join("", arryOfInput);
                }
                else
                {
                    output += " " + string.Join("", arryOfInput);
                }
            }

            Console.WriteLine(output);
        }
    }
}
