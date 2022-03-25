using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{
    public class UInt128
    {
        readonly ulong h;
        readonly ulong l;

        public UInt128(UInt128 value)
        {
            h = value.h;
            l = value.l;
        }

        public UInt128(ulong h, ulong l)
        {
            this.h = h;
            this.l = l;
        }

        public UInt128(ulong value)
        {
            l = value;
            h = 0;
        }

        public static readonly UInt128 MaxValue = new UInt128(ulong.MaxValue, ulong.MaxValue);
        public static readonly UInt128 MinValue = new UInt128(0);


        //public static UInt128 operator +(UInt128 a, UInt128 b)
        //{
        //    var l = a.lo + b.lo;
        //    var h = a.hi + b.hi;
        //    if (l <a.lo || l < b.hi)
        //    {
        //        return new UInt128(h+1, l);
        //    }
        //    else
        //        return new UInt128(h, l);
        //}

        public static UInt128 operator +(UInt128 a, UInt128 b)
        {
            var h = a.h + b.h;
            ulong l;
            try
            {
                l = checked(a.l + b.l);
                return new UInt128(h, l);
            }
            catch (OverflowException)
            {
                l = a.l + b.l;
                return new UInt128(h + 1, l);
            }

        }
        public static UInt128 operator ++(UInt128 value)
        {
            var l = value.l + 1;
            if (l != 0)
                return new UInt128(value.h, l);
            else
                return new UInt128(value.h + 1, l); //1111 + 0001 = 0000
        }

        public static bool operator ==(UInt128 a, UInt128 b)
        {
            throw new Exception();
        }
        public static bool operator !=(UInt128 a, UInt128 b)
        {
            throw new Exception();
        }

        public static bool operator >(UInt128 a, UInt128 b)
        {
            throw new Exception();
        }
        public static bool operator <(UInt128 a, UInt128 b)
        {
            throw new Exception();
        }
        public static bool operator >=(UInt128 a, UInt128 b)
        {
            throw new Exception();
        }
        public static bool operator <=(UInt128 a, UInt128 b)
        {
            throw new Exception();
        }

        public static UInt128 operator >>(UInt128 value, int count)
        {
            if (count >= 128) return 0;
            if (count >= 64) return value.h >> count;
            return new UInt128(value.h >> count, value.h << (64 - count) | value.l >> count);
        }
        public static UInt128 operator <<(UInt128 value, int count)
        {

            throw new Exception();

        }

        public static UInt128 operator &(UInt128 a, UInt128 b) => new UInt128(a.h & b.h, a.l & b.l);
        public static UInt128 operator |(UInt128 a, UInt128 b) => new UInt128(a.h | b.h, a.l | b.l);
        public static UInt128 operator ^(UInt128 a, UInt128 b) => new UInt128(a.h ^ b.h, a.l ^ b.l);

        public static UInt128 operator *(UInt128 a, UInt128 b)
        {
            UInt128 result = 0;
            for (int i = 0; i < 128; i++)
            {
                if ((b & 1) > 0) result += a;
                a <<= 1;
                b >>= 1;
            }
            return result;
        }

        public static (UInt128, UInt128) Div(UInt128 a, UInt128 b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            if (a < b) return (0, a);

            var hiBit = new UInt128(0x8000000000000000, 0);
            var result = new UInt128(0);
            int count = 0;
            // check count shift
            while ((b & hiBit) == 0 && (b << 1) <= a)
            {
                count++;
                b <<= 1;
            }


            while (count > 0)
            {
                count--;
                if (a >= b)
                {
                    result |= 1;
                    a -= b;
                }
                result <<= 1;
                b >>= 1;
            }
            if (a >= b)
            {
                a -= b;
                result |= 1;
            }
            return (result, a);
        }
        public static UInt128 operator /(UInt128 a, UInt128 b) => Div(a, b).Item1;
        public static UInt128 operator %(UInt128 a, UInt128 b) => Div(a, b).Item2;


        public static implicit operator UInt128(ulong value) => new UInt128(value);
        public static explicit operator ulong(UInt128 value) => value.l; // 32->64 + 32->64 = 64

        // ++ -- +x -x !x ~x true false (x -=a  x = x - a
        // a+b,a-b,a*b,a/b,a%b

        public static UInt128 operator -(UInt128 a, UInt128 b)
        {
            byte aa = 1;
            byte bb = 1;
            byte cc = (byte)(aa + bb);

            var l = a.l - b.l;
            var h = a.h - b.h;
            if (a.l < b.l)
                return new UInt128(h - 1, l);
            else
                return new UInt128(h, l);
        }
        public static UInt128 operator --(UInt128 value) // 0000 - 0001 = 1111
        {
            var l = value.l - 1;
            if (l != ulong.MaxValue)
                return new UInt128(value.h, l);
            else
                return new UInt128(value.h - 1, l);
        }

        public byte this[int i]
        {
            get 
            {
                if (i>16)
                    throw new ArgumentOutOfRangeException(nameof(i));
                //return (byte)(this >> i*8);

                if (i <= 8)
                {
                    return (byte)(l >> i * 8);
                }
                else
                {
                    return (byte)(h >> i * 8);
                }
                
             }
            set 
            {
                if (i > 16)
                    throw new ArgumentOutOfRangeException(nameof(i));
                var result = (new UInt128(value)) << i;
                var mask = ((new UInt128(0xff)) << i) ^ UInt128.MaxValue; //111100001111
                var s =(this & mask) | result;


            }
        }
        public ulong this[string s]
        {
            get
            {
                switch (s.ToLower())
                {
                    case "hi":
                    case "h":
                        return h;
                    case "lo":
                    case "l":
                        return l;
                        default: throw new ArgumentOutOfRangeException(nameof(s));
                }
 
            }
        }

    }
}
