using System;
namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqr1 = "1";
            string sqr2 = "2";
            string sqr3 = "3";
            string sqr4 = "4";
            string sqr5 = "5";
            string sqr6 = "6";
            string sqr7 = "7";
            string sqr8 = "8";
            string sqr9 = "9";
            string checknumber(string number)
            {
                if (number == "1" || number == "2" || number == "3" || number == "4" || number == "5" || number == "6" || number == "7" || number == "8" || number == "9")
                {
                    return "yes";
                }
                else
                {
                    return "no";
                }
            
            }

        }
    }
}