using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class RNGenerator
    {
        /// <summary>
        /// Random number generator
        /// </summary>
        static Random random = new Random();
        /// <summary>
        /// Get class name
        /// </summary>
        public static void GetClassName()
        {
            Console.WriteLine(nameof(RNGenerator));
        }
        /// <summary>
        /// Get random number
        /// </summary>
        /// <returns>Random integer</returns>
        public static int GetNext()
        {
            return random.Next();
        }
        /// <summary>
        /// Get random number in range
        /// </summary>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        /// <returns>Random integer in range</returns>
        public static int GetRange(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
