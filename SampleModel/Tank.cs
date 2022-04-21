using SampleModel.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel
{
    public class Tank
    {
        private ComplexBlock Block;
        private GainBlock kx1;
        private GainBlock kx2;
        private GainBlock kx3;
        private double y1 = 10;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private double dt = 0.1;
        public Tank(double dt) {
            this.dt = dt;
            kx1 = new GainBlock(1);
            kx2 = new GainBlock(-1);
            kx3 = new GainBlock(-1);


            Block = new ComplexBlock();

            Block.Add(new IntBlock(dt));
        }

        public double Calc(double x2, double y) {
            x2 = xLimit.Calc(x2);
            double x = 0;
            if (y > this.y1)
            {
                x = kx1.Calc(10) + kx2.Calc(x2) + kx3.Calc(5);
            }
            x = kx1.Calc(10) + kx2.Calc(x2);
            return Block.Calc(x);
        }
    }
}
