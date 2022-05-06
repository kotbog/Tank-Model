using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class Tank
    {
        private ComplexBlock block;
        private GainBlock gainIn1;
        private GainBlock gainIn2;
        private GainBlock gainOut1;
        private GainBlock gainOut2;
        private LimitBlock limit;
        private double dt = 0.1;
        private const double z1 = 5;
        public double level;
        private double input;
        public double Input { get { return input; } set { input = limit.Calc(value); } }
        public double Output;
        
        public Tank(double dt)
        {
            this.dt = dt;
            this.gainIn1 = new GainBlock(1);
            this.gainIn2 = new GainBlock(1);
            this.gainOut2 = new GainBlock(-1);
            this.gainOut1 = new GainBlock(-1);
            this.limit = new LimitBlock(0, 100);
            this.Output = 0;
            block = new ComplexBlock();
            block.Add(new LimitedIntBlock(dt, 0, 100));
        }


        public double Calc(double xIn1, double xIn2, double xOut1)
        {

            double x = (level > z1) ? gainIn1.Calc(xIn1) + gainIn2.Calc(xIn2) + gainOut1.Calc(xOut1) + gainOut2.Calc(1)
                : gainIn1.Calc(xIn1) + gainIn2.Calc(xIn2) + gainOut1.Calc(xOut1);
            this.level = block.Calc(x);
            this.level = limit.Calc(this.level);
            return this.level;
        }
    }
}
