using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class PIDBlock : BaseBlock
    {
        private double prevX = 0;
        private double dt;
        private double intSum = 0;
        private double ki = 1;

        public double UpLimit { get; set; } = 100;
        public double DownLimit { get; set; } = 0;
        public bool ManualMode { get; set; } = false;

        public double Umanual { get; set; }

        public double U { get; set; }

        public double K { get; set; } = 1;

        public double Ti
        {
            get { return 1 / ki; }
            set
            {
                if (value == 0) ki = double.MaxValue;
                else ki = 1 / value;
            }
        }
        public double Ki { get { return ki; } set { ki = value; } }
        public double Td { get; set; } = 0;

        public const double B = 1;
        public const double C = 1;


        public PIDBlock(double dt)
        {
            this.dt = dt;
        }
        public override double Calc(double x)
        {

            double u = 0;
            if (ManualMode)
            {
                intSum = (Umanual - K * (x - u) - Td * ((x - u) - prevX) / dt) / ki;
            } else
            {
                intSum += (prevX + (x - u)) * dt / 2;
            }
            // регулятор з ваговими коефіцієнтами
            u = K * (B * x - u) + ki * intSum + Td * ((C * x - u) - prevX) / dt;
            //double u = K * x + ki * intSum + Td * (x - prevX) / dt;
            bool limited = false;
            if (u > UpLimit)
            {
                u = UpLimit;
                limited = true;
            }
            if (u < DownLimit)
            {
                u = DownLimit;
                limited = true;
            }
            if (ki != 0 && limited)
            {
                intSum = (u - K * (B * x - u) - Td * ((C * x - u) - prevX) / dt) / ki;
            }
            prevX = x;
            U = u;
            return U;
        }
    }
}
