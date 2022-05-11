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


        ControlSystem system;
        
        
        
        //private ComplexBlock Block;
        //private LimitBlock xLimit = new LimitBlock(0,100);
        //private double y; // current level of water in tank
        //private double xIn1 = 0;
        //private double xIn2 = 0;
        //private double xOut1 = 0;
        //private double time = 0;
        private double dt = 0.1;
        

        //private Tank tank;
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

            system = new ControlSystem(dt);
            
            //tank = new Tank(dt);
            /* Block = new ComplexBlock();
             Block.Add(new NoiseBlock(2));
             Block.Add(new DelayBlock(dt,5));
             Block.Add(new GainBlock(5));
             Block.Add(new APBlock(dt, 5));            
             Block.Add(new APBlock(dt, 10));
             Block.Add(new NoiseBlock(2));*/
        }


        private void tmModel_Tick(object sender, EventArgs e) {

            system.Calc();

            //y = tank.Calc(xIn1, xIn2, xOut1);
            //y = xLimit.Calc(y);

            //time += dt; 
            
            lbY.Text = system.Output.ToString("F2");
            chMainPlot.Series[0].Points.AddXY(system.Time,system.Output);
            chMainPlot.Series[1].Points.AddXY(system.Time,system.Input1);
            chMainPlot.Series[2].Points.AddXY(system.Time,system.Input2);
            chMainPlot.Series[3].Points.AddXY(system.Time,system.Input3);

            //chMainPlot.Series[1].Points.AddXY(time,x);
        }

        private void btnStart_Click(object sender, EventArgs e) {
            tmModel.Start();
            btnMod.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e) {
            tmModel.Stop();
            
        }

        private void btnUp_Click(object sender, EventArgs e) {
            system.Input1 += 1;
            tbX.Text = system.Input1.ToString("F2");
        }

        private void btnDn_Click(object sender, EventArgs e) {
            system.Input1 -= 1;
            tbX.Text = system.Input1.ToString("F2");
        }

        private void btnX1_Click(object sender, EventArgs e) {
            tmModel.Interval = 1000;
        }

        private void btnX10_Click(object sender, EventArgs e) {
            tmModel.Interval = 100;
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            system.Input2 += 1;
            tbX1.Text = system.Input2.ToString("F2");
        }

        private void btnDn1_Click(object sender, EventArgs e)
        {
            system.Input2 -= 1;
            tbX1.Text = system.Input2.ToString("F2");
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            system.Input3 += 1;
            tbX2.Text = system.Input3.ToString("F2");
        }

        private void btnDn2_Click(object sender, EventArgs e)
        {
            system.Input3 -= 1;
            tbX2.Text = system.Input3.ToString("F2");
        }

        private void KbtnUp_Click(object sender, EventArgs e)
        {
            system.K += 1;
            Ktb.Text = system.K.ToString("F2");
        }

        private void KbtnDown_Click(object sender, EventArgs e)
        {
            system.K -= 1;
            Ktb.Text = system.K.ToString("F2");
        }

        private void TibtnDown_Click(object sender, EventArgs e)
        {
            system.Ti -= 1;
            Titb.Text = system.Ti.ToString("F2");
        }

        private void TibtnUp_Click(object sender, EventArgs e)
        {
            system.Ti += 1;
            Titb.Text = system.Ti.ToString("F2");
        }

        private void TdbtnDown_Click(object sender, EventArgs e)
        {
            system.Td -= 1;
            Tdtb.Text = system.Td.ToString("F2");
        }

        private void TdbtnUp_Click(object sender, EventArgs e)
        {
            system.Td += 1;
            Tdtb.Text = system.Td.ToString("F2");
        }

        private void SetbtnDown_Click(object sender, EventArgs e)
        {
            system.SetPoint -= 1;
            Settb.Text = system.SetPoint.ToString("F2");
        }

        private void SetbtnUp_Click(object sender, EventArgs e)
        {
            system.SetPoint += 1;
            Settb.Text = system.SetPoint.ToString("F2");
        }

        private void TiChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(Titb.Text, out val))
            {
                system.Ti = val;
            }
        }
        private void DisplayManualMode()
        {
            btnAuto.Text = system.ManualMode ? "Manual" : "Auto";
            btnMod.Text = system.ModifiedMode ? "Modified" : "Not Modified";
            btnDn1.Enabled = system.ManualMode;
            btnUp1.Enabled = system.ManualMode;
            tbX1.Enabled = system.ManualMode;

        }
        private void DisplayPidValues() {
            Titb.Text = system.Ti.ToString("F2");
            Tdtb.Text = system.Td.ToString("F2");
            Ktb.Text = system.K.ToString("F2");
            DisplayInputValues();
        }
        private void DisplayInputValues() {
            tbX.Text = system.Input1.ToString("F2");
            tbX2.Text = system.Input3.ToString("F2");
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            system.ManualMode = !system.ManualMode;
            DisplayManualMode();
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            DisplayManualMode();
            DisplayPidValues();
        }

        private void bBtnUp_Click(object sender, EventArgs e)
        {
            system.B += 0.1;
            bTb.Text = system.B.ToString("F2");
        }

        private void bBtnDown_Click(object sender, EventArgs e)
        {
            system.B -= 0.1;
            bTb.Text = system.B.ToString("F2");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            system.ModifiedMode = !system.ModifiedMode;
            DisplayManualMode();
        }

        private void CbtnUp_Click(object sender, EventArgs e)
        {
            system.C += 0.1;
            cTb.Text = system.C.ToString("F2");
        }

        private void CdbtnDown_Click(object sender, EventArgs e)
        {
            system.C -= 0.1;
            cTb.Text = system.C.ToString("F2");
        }
    }
}
