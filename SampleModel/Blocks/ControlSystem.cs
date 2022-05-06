using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel.Blocks
{
    public class ControlSystem
    {
        private Tank tank;
        private PIDBlock pid;
        private double dt;
        private LimitBlock xLimit = new LimitBlock(0, 100);

        public double Time = 0;
        public double SetPoint;

        private double input1;
        private double input2;
        private double input3;
        public bool ManualMode { get { return pid.ManualMode; } set { pid.ManualMode = value; } }
        public double Input1 { get { return input1; } set { input1 = xLimit.Calc(value); } }
        public double Input2 { get { return input2; } set { input2 = xLimit.Calc(value); } }
        public double Input3 { get { return input3; } set { input3 = xLimit.Calc(value); } }

        public double Output;


        public double K { get { return pid.K; } set { pid.K = value; } }
        public double Ti { get { return pid.Ti; } set { pid.Ti = value; } }
        public double Td { get { return pid.Td; } set { pid.Td = value; } }

        public ControlSystem(double dt)
        {
            this.dt = dt;
            tank = new Tank(dt);
            pid = new PIDBlock(dt);
        }

        public void Calc()
        {
            Output = tank.Calc(Input1, Input2, Input3);
            var e = SetPoint - Output;
            var u = pid.Calc(e);
            if(!ManualMode)
            {
                Input2 = u;
            }else
            {
                pid.Umanual = Input2;
            }

            Time += dt;
        }

    }
}
