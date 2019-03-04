using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    internal class MyInteger
    {
        public uint Value { get
            {
                return Value;
            }
            set
            {
                Value = value;
            }
        }
        private uint value2;

        public int Value2
        {
            get
            {
                return (int)value2;
            }
            set
            {
                if (value > 1000000)
                    throw new ArgumentOutOfRangeException("Value cannot be higher than 1000000");
                Minus = value < 0; // Side-effect VAD
                value2 = (uint)value;
            }
        }

        public int Value3 { get; set; } = 15;

        private static int GetMaxInt() { return int.MaxValue; }
        public int Value4 => GetMaxInt() * 3;

        public bool Minus { get; private set; }

        public MyInteger()
        {
        }

        public MyInteger(uint value, bool signed)
        {
            Value = value;
            Minus = signed;
        }

        public static implicit operator MyInteger(int v)
        {
            return new MyInteger() { Value = (uint)Math.Abs(v), Minus = v < 0 };
        }
    }

    public class ClassTest
    {
        public static void DoIt()
        {
            MyInteger myInteger = new MyInteger() { Value = 33};
            MyInteger myInteger2 = new MyInteger(33,true);
            MyInteger myInteger3 = 125;
        }
        

    }
}
