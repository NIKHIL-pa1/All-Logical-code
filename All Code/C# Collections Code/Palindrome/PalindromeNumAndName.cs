using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class PalindromeNumAndName
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromNum());
          
            Console.WriteLine(PalindromString());
        }

        static bool PalindromNum()
        {
            int Num = 121;
            int rev = 0;
            int temp = Num;
            while (Num > 0)
            {
                int rem = Num % 10;
                rev = rev * 10 + rem;
                Num = Num / 10;
            }

            if(temp ==  rev) return true;
            else return false;
        }

        static bool PalindromString()
        {
            string name = "Madam";
            string rev = "";

            string temp = name.ToLower();
            
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                rev += temp[i];
            }

            if(temp == rev)
                return true;
            else return false;


        }
    }
}
