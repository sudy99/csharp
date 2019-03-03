using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEI
{
    namespace BaseLib
    {   /// <summary>
        /// Trida Reading cte data zadana do konzole a vraci je ve zvolenych datovych typech
        /// </summary>
        public class Reading
        {/// <summary>
         /// Nacte cele cislo z konzole
         /// </summary>
         /// <param name="vyzva">vstupni zprava</param>
         /// <returns>integer</returns>
            public static int getInt(string vyzva)
            {
                Console.Write(vyzva);
                int i;
                    while(!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("Neplatná volba.\n"+vyzva);
                }
                
                return i;                
            }
            /// <summary>
            /// Nacte desetinne cislo z konzole
            /// </summary>
            /// <param name="vyzva">vstupni zprava</param>
            /// <returns>double</returns>
            public static double getDouble(string vyzva)
            {
                double d;
                Console.Write(vyzva);
                d = Convert.ToDouble(Console.ReadLine());
                return d;
            }
            /// <summary>
            /// Nacte znak z konzole
            /// </summary>
            /// <param name="vyzva">vstupni zprava</param>
            /// <returns>char</returns>
            public static char getChar(string vyzva)
            {
                char c;
                Console.Write(vyzva);
                c = Convert.ToChar(Console.ReadLine());
                return c;
            }
            /// <summary>
            /// Nacte z konzole textovy retezec
            /// </summary>
            /// <param name="vyzva"></param>
            /// <returns></returns>
            public static string getString(string vyzva)
            {
                string s;
                Console.Write(vyzva);
                s = Console.ReadLine();
                return s;
            }
        }
        /// <summary>
        /// Prevadi hodnoty mezi desitkovou a dvojkovou soustavou
        /// </summary>
        public class MathConvertor
        {
            /// <summary>
            /// Prevadi z desitkove do dvojkove soustavy
            /// </summary>
            /// <param name="hodnota">prevadena hodnota</param>
            /// <returns>integer</returns>
            public int PrevedDecBin(int hodnota)
            {
                return Convert.ToInt32(Convert.ToString(hodnota, 2));
            }
            /// <summary>
            /// Prevadi z dvojkove do desitkove soustavy
            /// </summary>
            /// <param name="hodnota">prevadena hodnota</param>
            /// <returns>integer</returns>
            public int PrevedBinDec(int hodnota)
            {
                return Convert.ToInt32(Convert.ToString(hodnota, 10));
            }
        }
    }
}

