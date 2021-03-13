using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Helpers
{
    public class Helpers
    {
        public static int Randomize(int min,int max) 
        {
            Random a = new Random();
            return a.Next(min, max);
        }

        public static string GoodBye()
        {
            int a = Randomize(1, 6);
            switch(a)
            {
                case 1:
                    return "Have a nice day!";
                case 2:
                    return "Enjoy the day!";
                case 3:
                    return "Enjoy the Encryption!";
                case 4:
                    return "See ya!";
                case 5:
                    return "Good day to You Sir!";
                case 6:
                    return "Till the next time!";
                default:
                    return "Error";
            }
        }
    }
}
