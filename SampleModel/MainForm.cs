using SampleModel.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleModel
{
    public partial class MainForm : Form
    {
        //private ComplexBlock Block;
        private LimitBlock xLimit = new LimitBlock(0,100);
        private double y; // current level of water in tank
        private double xIn1 = 0;
        private double xIn2 = 0;
        private double xOut1 = 0;
        private double time = 0;
        private double dt = 0.1;
        

        private Tank tank;
        //private double calcY(double x1, double x2, double x3)
        //{
        //    GainBlock gain1 = new GainBlock(1);
        //    GainBlock gain2 = new GainBlock(1);
        //    GainBlock gain3 = new GainBlock(-1);
        //    GainBlock gain4 = new GainBlock(1);
        //    IntBlock intBlock = new IntBlock(1);
        //    if(y > z1)
        //    {
        //        return gain1.Calc(x1) + gain2.Calc(x2) + gain3.Calc(x3) + gain4.Calc(x4) - intBlock.Calc(1);
        //    }
        //    return gain1.Calc(x1) + gain2.Calc(x2) + gain3.Calc(x3) - intBlock.Calc(1);
        //}
        public MainForm() {
            InitializeComponent();
            tank = new Tank(dt);
            /* Block = new ComplexBlock();
             Block.Add(new NoiseBlock(2));
             Block.Add(new DelayBlock(dt,5));
             Block.Add(new GainBlock(5));
             Block.Add(new APBlock(dt, 5));            
             Block.Add(new APBlock(dt, 10));
             Block.Add(new NoiseBlock(2));*/
        }


        private void tmModel_Tick(object sender, EventArgs e) {
            y = tank.Calc(xIn1, xIn2, xOut1);
            //y = xLimit.Calc(y);
            time += dt; 
            lbY.Text = y.ToString("F2");
            chMainPlot.Series[0].Points.AddXY(time,y);
            //chMainPlot.Series[1].Points.AddXY(time,x);
        }

        private void btnStart_Click(object sender, EventArgs e) {
            tmModel.Start();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            tmModel.Stop();
        }

        private void btnUp_Click(object sender, EventArgs e) {
            xIn1 += 1;
            xIn1 = xLimit.Calc(xIn1);
            tbX.Text = xIn1.ToString("F2");
        }

        private void btnDn_Click(object sender, EventArgs e) {
            xIn1 -= 1;
            xIn1 = xLimit.Calc(xIn1); 
            tbX.Text = xIn1.ToString("F2");
        }

        private void btnX1_Click(object sender, EventArgs e) {
            tmModel.Interval = 1000;
        }

        private void btnX10_Click(object sender, EventArgs e) {
            tmModel.Interval = 100;
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            xIn2 += 1;
            xIn2 = xLimit.Calc(xIn2);
            tbX1.Text = xIn2.ToString("F2");
        }

        private void btnDn1_Click(object sender, EventArgs e)
        {
            xIn2 -= 1;
            xIn2 = xLimit.Calc(xIn2);
            tbX1.Text = xIn2.ToString("F2");
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            xOut1 += 1;
            xOut1 = xLimit.Calc(xOut1);
            tbX2.Text = xOut1.ToString("F2");
        }

        private void btnDn2_Click(object sender, EventArgs e)
        {
            xOut1 -= 1;
            xOut1 = xLimit.Calc(xOut1);
            tbX2.Text = xOut1.ToString("F2");
        }
    }
}
