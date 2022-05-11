using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class PIDBlock : BaseBlock
    {
        protected double prevX = 0;
        protected double dt;
        protected double intSum = 0;
        protected double ki = 1;

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




        public PIDBlock(double dt)
        {
            this.dt = dt;
        }
        public override double Calc(double x)
        {

            double u = 0;
            if (ManualMode)
            {
                intSum = (Umanual - K * x - Td * (x - prevX) / dt) / ki;
            }
            else
            {
                intSum += (prevX + x) * dt / 2;
            }
            // регулятор з ваговими коефіцієнтами
            u = K * x + ki * intSum + Td * (x - prevX) / dt;
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
                intSum = (u - K * x - Td * (x - prevX) / dt) / ki;
            }
            prevX = x;
            U = u;
            return U;
        }
    }
}
