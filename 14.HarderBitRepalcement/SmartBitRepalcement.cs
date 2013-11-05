/* * 14. Write a program that exchanges bits {p, p+1, …, p+k-1) 
 * with bits {q, q+1, …, q+k-1} of 
 * given 32-bit unsigned integer.
 * Much Regards to the forum help !
 */

using System;
using System.Linq;
using System.Collections.Generic;

class SmartBitRepalcement
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary is :");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("How many bits you wont to change:");
        int numberOfBits = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the start postion:");
        int startPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end position:");
        int endPosition = int.Parse(Console.ReadLine());
   
        string numberBinStr = Convert.ToString(number, 2).PadLeft(32, '0');
        //making a list using System.Collections.Generic
        List<char> numberBin = new List<char>();
        //making each digit in the binary number to correspond with a index of the list
        for (int i = 0; i < numberBinStr.Length; i++)
        {
            numberBin.Add(numberBinStr[i]);
        }
        //the list starts from left to right and the binary starts from right to left
        numberBin.Reverse();

        //making new list to save our changed bits
        List<char> numberBinChanged = new List<char>();

        //adding the digits to the new list 
        for (int i = 0; i < numberBin.Count; i++)
        {
            //changing the digits from the end position to the start position
            if (i==startPosition)
            {
                for (int j = 0; j < numberOfBits; j++)
                {
                    numberBinChanged.Add(numberBin[endPosition + j]);
                }
                i += numberOfBits-1;
            }
            //changing the digits from the start position to the end position
            else if (i==endPosition)
            {
                for (int j = 0; j < numberOfBits; j++)
                {
                    numberBinChanged.Add(numberBin[startPosition + j]);
                }
                i += numberOfBits-1;
            }
            // adding the remainig digits
            else 
            {
                numberBinChanged.Add(numberBin[i]);
            }                    
        }
        //returning to binary lineup
        numberBinChanged.Reverse();
        //printing the new list with replaced digits
        for (int k = 0; k < numberBinChanged.Count; k++)
        {
            Console.Write(numberBinChanged[k]);
        }
        Console.WriteLine();
    }
}
