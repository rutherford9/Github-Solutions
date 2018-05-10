using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralAlgorithm
{
    class RomanNumeralLogic
    {
        //make dictionary that has char as key, and int as value
        public Dictionary<char, int> ItemsLib = new Dictionary<char, int>()
        {
            {'I', 1},

            {'V', 5},

            {'X', 10},

            {'L', 50},

            {'C', 100},

            {'D', 500},

            {'M', 1000},
        };
       //method that accepts string of chars(roman numerals), returns value
        public int RomanToInt(string romanString)
        {
            //initialize sum, which will ultimately be return value, and counter, which will be used when adding 
            //to determine when to finally skip it.
            int sum = 0;
            int counter = 0;
            //for loop with -1 for 0 adjust, decrement until iterates through string
            for (int i = romanString.Length - 1; i >= 0; i--)
            {
                char ch = romanString[i];
                //conditional to initiate so long as character in questions value is greater than counter, for the purposes
                //of skipping the subtraction logic for 4, 9, etc..
                if (ItemsLib[ch] >= counter)
                {
                    //sum gets added for total
                    sum += ItemsLib[ch];
                    counter = ItemsLib[ch];
                    //continue ensures the subtract logic gets skipped and jumps back to the next loop iteration
                    continue;
                }
                //for 4 and 9, this will execute
                sum -= ItemsLib[ch];

            }
            //return sum
            return sum;
        }
    }
}

