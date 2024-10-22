using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticclasstask
{
    internal  static class Helper
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;

        }

        public static bool HasDigit(this string name)
        {
            for(int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    return true;
                }

            }
            return false;
        }

        public static bool CheckPassword(this string password)
        {
           
            
                if (password.Length < 8)
                {
                    return false;
                }

                bool isdigit = false;
                bool isupper = false;
                bool islower = false;
                foreach(char a in password)
                {
                    if (Char.IsDigit(a))
                    {
                        isdigit = true;
                    }
                    else if (Char.IsUpper(a))
                    {
                        isupper = true;
                    }
                    else if (Char.IsLower(a))
                    {
                        islower = true;
                    }


                }
                if (islower && isupper && isdigit)
                {
                    return true;
                }
            return false;

              
          
        }

        public static string  Capitalize(this string Name)
        {
            return Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower();
        }
    }
}
