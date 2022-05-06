namespace SampleModel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.chMainPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbY = new System.Windows.Forms.Label();
            this.lbYCaption = new System.Windows.Forms.Label();
            this.tmModel = new System.Windows.Forms.Timer(this.components);
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.btnUp1 = new System.Windows.Forms.Button();
            this.btnDn1 = new System.Windows.Forms.Button();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnDn2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gout1 = new System.Windows.Forms.Label();
            this.Gin2 = new System.Windows.Forms.Label();
            this.Gin1 = new System.Windows.Forms.Label();
            this.Ktb = new System.Windows.Forms.TextBox();
            this.KbtnUp = new System.Windows.Forms.Button();
            this.KbtnDown = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Label();
            this.Titb = new System.Windows.Forms.TextBox();
            this.TibtnUp = new System.Windows.Forms.Button();
            this.TibtnDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tdtb = new System.Windows.Forms.TextBox();
            this.TdbtnUp = new System.Windows.Forms.Button();
            this.TdbtnDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Settb = new System.Windows.Forms.TextBox();
            this.SetbtnUp = new System.Windows.Forms.Button();
            this.SetbtnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(754, 440);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 19);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(693, 440);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(164, 36);
            this.tbX.Margin = new System.Windows.Forms.Padding(2);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(48, 20);
            this.tbX.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(217, 37);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 19);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(139, 36);
            this.btnDn.Margin = new System.Windows.Forms.Padding(2);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(20, 19);
            this.btnDn.TabIndex = 4;
            this.btnDn.Text = "<";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // chMainPlot
            // 
            this.chMainPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "chMainArea";
            this.chMainPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chMainPlot.Legends.Add(legend1);
            this.chMainPlot.Location = new System.Drawing.Point(9, 60);
            this.chMainPlot.Margin = new System.Windows.Forms.Padding(2);
            this.chMainPlot.Name = "chMainPlot";
            series1.BorderWidth = 3;
            series1.ChartArea = "chMainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Y";
            series1.Name = "seriesY";
            series2.ChartArea = "chMainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SeriesX1";
            series3.ChartArea = "chMainArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "SeriesX2";
            series4.ChartArea = "chMainArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "SeriesX3";
            this.chMainPlot.Series.Add(series1);
            this.chMainPlot.Series.Add(series2);
            this.chMainPlot.Series.Add(series3);
            this.chMainPlot.Series.Add(series4);
            this.chMainPlot.Size = new System.Drawing.Size(502, 359);
            this.chMainPlot.TabIndex = 5;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(67, 45);
            this.lbY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(22, 13);
            this.lbY.TabIndex = 7;
            this.lbY.Text = "0.0";
            // 
            // lbYCaption
            // 
            this.lbYCaption.AutoSize = true;
            this.lbYCaption.Location = new System.Drawing.Point(48, 45);
            this.lbYCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYCaption.Name = "lbYCaption";
            this.lbYCaption.Size = new System.Drawing.Size(17, 13);
            this.lbYCaption.TabIndex = 8;
            this.lbYCaption.Text = "Y:";
            // 
            // tmModel
            // 
            this.tmModel.Interval = 1000;
            this.tmModel.Tick += new System.EventHandler(this.tmModel_Tick);
            // 
            // btnX1
            // 
            this.btnX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX1.Location = new System.Drawing.Point(9, 440);
            this.btnX1.Margin = new System.Windows.Forms.Padding(2);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(56, 19);
            this.btnX1.TabIndex = 9;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX10.Location = new System.Drawing.Point(70, 440);
            this.btnX10.Margin = new System.Windows.Forms.Padding(2);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(56, 19);
            this.btnX10.TabIndex = 10;
            this.btnX10.Text = "x10";
            this.btnX10.UseVisualStyleBackColor = true;
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(310, 36);
            this.tbX1.Margin = new System.Windows.Forms.Padding(2);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(48, 20);
            this.tbX1.TabIndex = 2;
            // 
            // btnUp1
            // 
            this.btnUp1.Location = new System.Drawing.Point(363, 37);
            this.btnUp1.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp1.Name = "btnUp1";
            this.btnUp1.Size = new System.Drawing.Size(20, 19);
            this.btnUp1.TabIndex = 3;
            this.btnUp1.Text = ">";
            this.btnUp1.UseVisualStyleBackColor = true;
            this.btnUp1.Click += new System.EventHandler(this.btnUp1_Click);
            // 
            // btnDn1
            // 
            this.btnDn1.Location = new System.Drawing.Point(285, 36);
            this.btnDn1.Margin = new System.Windows.Forms.Padding(2);
            this.btnDn1.Name = "btnDn1";
            this.btnDn1.Size = new System.Drawing.Size(20, 19);
            this.btnDn1.TabIndex = 4;
            this.btnDn1.Text = "<";
            this.btnDn1.UseVisualStyleBackColor = true;
            this.btnDn1.Click += new System.EventHandler(this.btnDn1_Click);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(451, 36);
            this.tbX2.Margin = new System.Windows.Forms.Padding(2);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(48, 20);
            this.tbX2.TabIndex = 2;
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(504, 37);
            this.btnUp2.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(20, 19);
            this.btnUp2.TabIndex = 3;
            this.btnUp2.Text = ">";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnDn2
            // 
            this.btnDn2.Location = new System.Drawing.Point(426, 36);
            this.btnDn2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDn2.Name = "btnDn2";
            this.btnDn2.Size = new System.Drawing.Size(20, 19);
            this.btnDn2.TabIndex = 4;
            this.btnDn2.Text = "<";
            this.btnDn2.UseVisualStyleBackColor = true;
            this.btnDn2.Click += new System.EventHandler(this.btnDn2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Gout1
            // 
            this.Gout1.AutoSize = true;
            this.Gout1.Location = new System.Drawing.Point(448, 9);
            this.Gout1.Name = "Gout1";
            this.Gout1.Size = new System.Drawing.Size(36, 13);
            this.Gout1.TabIndex = 12;
            this.Gout1.Text = "Gout1";
            // 
            // Gin2
            // 
            this.Gin2.AutoSize = true;
            this.Gin2.Location = new System.Drawing.Point(307, 9);
            this.Gin2.Name = "Gin2";
            this.Gin2.Size = new System.Drawing.Size(29, 13);
            this.Gin2.TabIndex = 12;
            this.Gin2.Text = "Gin2";
            // 
            // Gin1
            // 
            this.Gin1.AutoSize = true;
            this.Gin1.Location = new System.Drawing.Point(161, 9);
            this.Gin1.Name = "Gin1";
            this.Gin1.Size = new System.Drawing.Size(29, 13);
            this.Gin1.TabIndex = 12;
            this.Gin1.Text = "Gin1";
            // 
            // Ktb
            // 
            this.Ktb.Location = new System.Drawing.Point(557, 214);
            this.Ktb.Margin = new System.Windows.Forms.Padding(2);
            this.Ktb.Name = "Ktb";
            this.Ktb.Size = new System.Drawing.Size(48, 20);
            this.Ktb.TabIndex = 2;
            // 
            // KbtnUp
            // 
            this.KbtnUp.Location = new System.Drawing.Point(610, 215);
            this.KbtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.KbtnUp.Name = "KbtnUp";
            this.KbtnUp.Size = new System.Drawing.Size(20, 19);
            this.KbtnUp.TabIndex = 3;
            this.KbtnUp.Text = ">";
            this.KbtnUp.UseVisualStyleBackColor = true;
            this.KbtnUp.Click += new System.EventHandler(this.KbtnUp_Click);
            // 
            // KbtnDown
            // 
            this.KbtnDown.Location = new System.Drawing.Point(532, 214);
            this.KbtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.KbtnDown.Name = "KbtnDown";
            this.KbtnDown.Size = new System.Drawing.Size(20, 19);
            this.KbtnDown.TabIndex = 4;
            this.KbtnDown.Text = "<";
            this.KbtnDown.UseVisualStyleBackColor = true;
            this.KbtnDown.Click += new System.EventHandler(this.KbtnDown_Click);
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Location = new System.Drawing.Point(554, 199);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(14, 13);
            this.K.TabIndex = 12;
            this.K.Text = "K";
            // 
            // Titb
            // 
            this.Titb.Location = new System.Drawing.Point(557, 257);
            this.Titb.Margin = new System.Windows.Forms.Padding(2);
            this.Titb.Name = "Titb";
            this.Titb.Size = new System.Drawing.Size(48, 20);
            this.Titb.TabIndex = 2;
            this.Titb.TextChanged += new System.EventHandler(this.TiChanged);
            // 
            // TibtnUp
            // 
            this.TibtnUp.Location = new System.Drawing.Point(610, 258);
            this.TibtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.TibtnUp.Name = "TibtnUp";
            this.TibtnUp.Size = new System.Drawing.Size(20, 19);
            this.TibtnUp.TabIndex = 3;
            this.TibtnUp.Text = ">";
            this.TibtnUp.UseVisualStyleBackColor = true;
            this.TibtnUp.Click += new System.EventHandler(this.TibtnUp_Click);
            // 
            // TibtnDown
            // 
            this.TibtnDown.Location = new System.Drawing.Point(532, 257);
            this.TibtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.TibtnDown.Name = "TibtnDown";
            this.TibtnDown.Size = new System.Drawing.Size(20, 19);
            this.TibtnDown.TabIndex = 4;
            this.TibtnDown.Text = "<";
            this.TibtnDown.UseVisualStyleBackColor = true;
            this.TibtnDown.Click += new System.EventHandler(this.TibtnDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ti";
            // 
            // Tdtb
            // 
            this.Tdtb.Location = new System.Drawing.Point(557, 299);
            this.Tdtb.Margin = new System.Windows.Forms.Padding(2);
            this.Tdtb.Name = "Tdtb";
            this.Tdtb.Size = new System.Drawing.Size(48, 20);
            this.Tdtb.TabIndex = 2;
            // 
            // TdbtnUp
            // 
            this.TdbtnUp.Location = new System.Drawing.Point(610, 300);
            this.TdbtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.TdbtnUp.Name = "TdbtnUp";
            this.TdbtnUp.Size = new System.Drawing.Size(20, 19);
            this.TdbtnUp.TabIndex = 3;
            this.TdbtnUp.Text = ">";
            this.TdbtnUp.UseVisualStyleBackColor = true;
            this.TdbtnUp.Click += new System.EventHandler(this.TdbtnUp_Click);
            // 
            // TdbtnDown
            // 
            this.TdbtnDown.Location = new System.Drawing.Point(532, 299);
            this.TdbtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.TdbtnDown.Name = "TdbtnDown";
            this.TdbtnDown.Size = new System.Drawing.Size(20, 19);
            this.TdbtnDown.TabIndex = 4;
            this.TdbtnDown.Text = "<";
            this.TdbtnDown.UseVisualStyleBackColor = true;
            this.TdbtnDown.Click += new System.EventHandler(this.TdbtnDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Td";
            // 
            // Settb
            // 
            this.Settb.Location = new System.Drawing.Point(693, 215);
            this.Settb.Margin = new System.Windows.Forms.Padding(2);
            this.Settb.Name = "Settb";
            this.Settb.Size = new System.Drawing.Size(48, 20);
            this.Settb.TabIndex = 2;
            // 
            // SetbtnUp
            // 
            this.SetbtnUp.Location = new System.Drawing.Point(746, 216);
            this.SetbtnUp.Margin = new System.Windows.Forms.Padding(2);
            this.SetbtnUp.Name = "SetbtnUp";
            this.SetbtnUp.Size = new System.Drawing.Size(20, 19);
            this.SetbtnUp.TabIndex = 3;
            this.SetbtnUp.Text = ">";
            this.SetbtnUp.UseVisualStyleBackColor = true;
            this.SetbtnUp.Click += new System.EventHandler(this.SetbtnUp_Click);
            // 
            // SetbtnDown
            // 
            this.SetbtnDown.Location = new System.Drawing.Point(668, 215);
            this.SetbtnDown.Margin = new System.Windows.Forms.Padding(2);
            this.SetbtnDown.Name = "SetbtnDown";
            this.SetbtnDown.Size = new System.Drawing.Size(20, 19);
            this.SetbtnDown.TabIndex = 4;
            this.SetbtnDown.Text = "<";
            this.SetbtnDown.UseVisualStyleBackColor = true;
            this.SetbtnDown.Click += new System.EventHandler(this.SetbtnDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SetPoint";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(691, 299);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 13;
            this.btnAuto.Text = "Manual";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 469);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.K);
            this.Controls.Add(this.Gin1);
            this.Controls.Add(this.Gin2);
            this.Controls.Add(this.Gout1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.lbYCaption);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.chMainPlot);
            this.Controls.Add(this.btnDn2);
            this.Controls.Add(this.btnDn1);
            this.Controls.Add(this.TdbtnDown);
            this.Controls.Add(this.TibtnDown);
            this.Controls.Add(this.SetbtnDown);
            this.Controls.Add(this.KbtnDown);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.btnUp1);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.TdbtnUp);
            this.Controls.Add(this.TibtnUp);
            this.Controls.Add(this.SetbtnUp);
            this.Controls.Add(this.KbtnUp);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.Tdtb);
            this.Controls.Add(this.Titb);
            this.Controls.Add(this.Settb);
            this.Controls.Add(this.Ktb);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Sample model";
            this.Load += new System.EventHandler(this.OnLoadForm);
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMainPlot;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbYCaption;
        private System.Windows.Forms.Timer tmModel;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX10;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.Button btnUp1;
        private System.Windows.Forms.Button btnDn1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnDn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gout1;
        private System.Windows.Forms.Label Gin2;
        private System.Windows.Forms.Label Gin1;
        private System.Windows.Forms.TextBox Ktb;
        private System.Windows.Forms.Button KbtnUp;
        private System.Windows.Forms.Button KbtnDown;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.TextBox Titb;
        private System.Windows.Forms.Button TibtnUp;
        private System.Windows.Forms.Button TibtnDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tdtb;
        private System.Windows.Forms.Button TdbtnUp;
        private System.Windows.Forms.Button TdbtnDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Settb;
        private System.Windows.Forms.Button SetbtnUp;
        private System.Windows.Forms.Button SetbtnDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAuto;
    }
}

