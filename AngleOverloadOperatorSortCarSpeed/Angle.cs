using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleOverloadOperatorSortCarSpeed
{
    public class Angle
    {
        // *60
        private int _deg;
        private int _min;
        private int _sec;

        public int Degree { get; private set; }

        public Angle(int degree, int minutes, int seconds)
        {
            _deg = degree;
            _min = minutes;
            _sec = seconds;
        }

        public Angle(Angle ang)
        {
            _deg = ang._deg;
            _min = ang._min;
            _sec = ang._sec;
        }

        public static Angle operator +(Angle ang1, Angle ang2)
        {
            Angle temp = new Angle(ang1);
            temp._sec += ang2._sec;
            temp._min += ang2._min;
            temp._deg += ang2._deg;
            // recall to 60
            temp._min += (int)Math.Round((double)temp._sec / 60, 1);
            temp._deg += (int)Math.Round((double)temp._min / 60, 1);
            temp._min = Math.Abs(temp._min % 60);
            temp._sec = Math.Abs(temp._sec % 60);
            return temp;
        }

        public static Angle operator -(Angle ang1, Angle ang2)
        {
            Angle temp = new Angle(ang1);
            temp._sec -= ang2._sec;
            temp._min -= ang2._min;
            temp._deg -= ang2._deg;
            
            if (temp._sec < 0)
            {
                temp._sec += 60;
                temp._min -= 1;
            }

            if (temp._min < 0)
            {   
                temp._min += 60;
                temp._deg -= 1;
            }
            // recall to 60
            temp._min -= (int)Math.Round((double)temp._sec / 60, 1);
            temp._deg -= (int)Math.Round((double)temp._min / 60, 1);
            temp._min = Math.Abs(temp._min % 60);
            temp._sec = Math.Abs(temp._sec % 60);
            return temp;
        }


        public override string ToString()
        {
            return _deg +"d " + _min + "m " + _sec +"s";

        }
    }
}
