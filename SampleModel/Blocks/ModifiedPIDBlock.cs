using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    class ModifiedPIDBlock : PIDBlock
    {
        public ModifiedPIDBlock(double dt) : base(dt)
        {
            this.dt = dt;
        }
        public ModifiedPIDBlock(double dt, double b, double c) : base(dt)
        {
            B = b;
            C = c; 
        }
        public double B = 1;
        public double C = 1;
        public override double Calc(double x)
        {

            double u = 0;
            if (ManualMode)
            {
                intSum = (Umanual - K * (x - u) - Td * ((x - u) - prevX) / dt) / ki;
            }
            else
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
