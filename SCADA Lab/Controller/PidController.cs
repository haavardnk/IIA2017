using System;

namespace Controller
{
    public class PidController
    {
        public double Td { get; set; }
        public double Ti { get; set; }
        public double Kp { get; set; }
        public double OutputMax { get; set; }
        public double OutputMin { get; set; }
        public double SetPoint { get; set; } = 0;
        public double ErrorLast { get; private set; } = 0;
        public double Integral { get; private set; } = 0;

        public PidController(double kp, double ti, double td, double outputMax, double outputMin)
        {
            Td = td;
            Ti = ti;
            Kp = kp;
            OutputMax = outputMax;
            OutputMin = outputMin;
        }

        public double ControlVariable(double r, double dt)
        {
            var error = SetPoint - r;
            Integral = Integral + error * dt;
            var derivative = (error - ErrorLast) / dt;
            ErrorLast = error;

            var output = Kp * error + Limit(Kp / Ti * Integral) + Kp * Td * derivative;
    
            return Limit(output);
        }

        public double Limit(double u)
        {
            if (u <= OutputMin) { return OutputMin; }
            return u >= OutputMax ? OutputMax : u;
        }
    }
}