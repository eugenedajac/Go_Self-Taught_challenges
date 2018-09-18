using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePasswordGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
                
            Console.WriteLine("New Password : " + GeneratePassword());
            Console.ReadLine();
        }

        public static string GeneratePassword()
        {
            Random rand = new Random();
            int pwdLength = rand.Next(8, 21);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= pwdLength; i++)
            {
                int charType = rand.Next(1, 7);
                char charValue = '\0';
                switch (charType)
                {
                    case 1:
                        charValue = Convert.ToChar(rand.Next(65, 91)); //uppercase
                        break;
                    case 2:
                        charValue = Convert.ToChar(rand.Next(97, 123)); //lowercase
                        break;
                    case 3:
                        charValue = Convert.ToChar(rand.Next(48, 58)); //number
                        break;
                    case 4:
                        charValue = Convert.ToChar(rand.Next(58, 64)); //symbol 1
                        break;
                    case 5:
                        charValue = Convert.ToChar(rand.Next(33, 48)); //symbol 2
                        break;
                    case 6:
                        charValue = Convert.ToChar(rand.Next(91, 97)); //symbol 3
                        break;
                    case 7:
                        charValue = Convert.ToChar(rand.Next(123, 127)); //symbol 4
                        break;
                }
                sb.Append(charValue.ToString());
            }
            return sb.ToString();
        }
    }
}
