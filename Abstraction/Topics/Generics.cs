using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Topics
{
    public  class Calculate<T> //it can be added to the class expecially in a case where it is to be used in more than one method to make code readable

    {
        // Generics allows you to design your class and method in a way that you can input any type of data type without affecting your codes
        // they are extensively use by collection classes
        public static bool EqualValue(T v1,T v2)
        {
            return v1.Equals(v2);
        }

        public static int Add(T v1, T v2, T v3)
        {
            return 0;
        }

    }
}
