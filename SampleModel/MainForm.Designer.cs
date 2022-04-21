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
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(754, 337);
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
            this.btnStart.Location = new System.Drawing.Point(693, 337);
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
            series1.ChartArea = "chMainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Y";
            series1.Name = "seriesY";
            this.chMainPlot.Series.Add(series1);
            this.chMainPlot.Size = new System.Drawing.Size(516, 273);
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
            this.btnX1.Location = new System.Drawing.Point(9, 337);
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
            this.btnX10.Location = new System.Drawing.Point(70, 337);
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
            this.pictureBox1.Location = new System.Drawing.Point(545, 94);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 366);
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
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.btnUp1);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Sample model";
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
    }
}

