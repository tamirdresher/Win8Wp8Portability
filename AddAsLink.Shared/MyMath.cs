using System;
using System.Collections.Generic;
using System.Linq;
public static class MyMath
{


    public static int CountPairs(IEnumerable<int> numbers)
    {
        return numbers.Count(num => num % 2 == 0);
    }

    #region Optimize?
    //public static int CountPairs(IEnumerable<int> numbers)
    //{
    //    return numbers.AsParallel().Count(num => num % 2 == 0);
    //}
    #endregion //in parallel

    #region Optimize? 2

//    public static int CountPairs(IEnumerable<int> numbers)
//    {
//#if NETFX_CORE
//        return numbers.AsParallel().Count(num => num % 2 == 0);
//#else
//        return numbers.Count(num => num % 2 == 0);
//#endif
//    }

    #endregion //in parallel
}