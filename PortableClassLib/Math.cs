using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace PortableClassLib
{
    public static class MyMath   
    {
        public static int CountPairs(IEnumerable<int> numbers)
        {
            return numbers.Count(num => num % 2 == 0);
        }
    }
}
