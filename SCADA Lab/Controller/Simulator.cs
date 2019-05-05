using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class Simulator
    {
        public double ThetaT { get; set; }
        public double ThetaD { get; set; }
        public double Kh { get; set; }
        public double TempEnv { get; set; }
        public double ProcessVariable { get; private set; }
        private double _tempOutNext;
        private readonly List<double> _delayedU;


        public Simulator(double kh, double thetaT, double thetaD, double tempEnv)
        {
            Kh = kh;
            ThetaT = thetaT;
            ThetaD = thetaD;
            TempEnv = tempEnv;

            _delayedU = Enumerable.Repeat(0.0, 100).ToList();
        }

        public double Simulate(double u, double dt)
        {
            var tempOut = _tempOutNext;
            var delayedU = TimeDelay(u, dt);
            var dTempHeat = (1 / ThetaT) * (-tempOut + Kh * delayedU);

            ProcessVariable = tempOut + TempEnv;
            _tempOutNext = _tempOutNext + dt * dTempHeat;

            return ProcessVariable;
        }

        public double TimeDelay(double u, double dt)
        {
            _delayedU.Insert(0, u);
            _delayedU.RemoveAt(_delayedU.Count - 1);

            var index = Convert.ToInt32(ThetaD / dt);

            return Math.Abs(_delayedU[index]) < 0.001 ? u : _delayedU[index];
        }
    }
}