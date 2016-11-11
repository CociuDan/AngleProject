using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleProject
{
    public class Angle
    {
        public int Degrees { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public Angle(int degree, int minutes, int seconds)
        {
            if (seconds >= 60)
            {
                minutes = minutes + 1;
                seconds = seconds - 60;
            }
            if (minutes >= 60)
            {
                degree = degree + 1;
                minutes = minutes - 60;
            }

            Degrees = degree;
            Minutes = minutes;
            Seconds = seconds;
        }

        public static Angle operator +(Angle lAngle, Angle rAngle)
        {
            return new Angle(lAngle.Degrees + rAngle.Degrees, lAngle.Minutes + rAngle.Minutes, lAngle.Seconds + rAngle.Seconds);
        }

        public static Angle operator -(Angle lAngle, Angle rAngle)
        {
            if (rAngle.Seconds > lAngle.Seconds)
            {
                lAngle.Minutes = lAngle.Minutes - 1;
                lAngle.Seconds = lAngle.Seconds + 60;
            }
            if (rAngle.Minutes > lAngle.Minutes)
            {
                lAngle.Degrees = lAngle.Degrees - 1;
                lAngle.Minutes = lAngle.Minutes + 60;
            }
            if (rAngle.Degrees > lAngle.Degrees)
            {
                return new Angle(lAngle.Degrees - rAngle.Degrees, lAngle.Minutes - rAngle.Minutes, lAngle.Seconds - rAngle.Seconds);
            }
            else
            {
                return new Angle(lAngle.Degrees - rAngle.Degrees, lAngle.Minutes - rAngle.Minutes, lAngle.Seconds - rAngle.Seconds);
            }
        }
    }
}
