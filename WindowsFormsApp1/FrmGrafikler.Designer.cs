namespace WindowsFormsApp1
{
    partial class FrmGrafikler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafikler = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.LBLA = new System.Windows.Forms.Label();
            this.LBLB = new System.Windows.Forms.Label();
            this.LBLC = new System.Windows.Forms.Label();
            this.LBLD = new System.Windows.Forms.Label();
            this.LBLE = new System.Windows.Forms.Label();
            this.grafikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafikler
            // 
            this.grafikler.Controls.Add(this.chart1);
            this.grafikler.Location = new System.Drawing.Point(12, 33);
            this.grafikler.Name = "grafikler";
            this.grafikler.Size = new System.Drawing.Size(1026, 346);
            this.grafikler.TabIndex = 0;
            this.grafikler.TabStop = false;
            this.grafikler.Text = "grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 27);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1020, 316);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBLE);
            this.groupBox2.Controls.Add(this.LBLD);
            this.groupBox2.Controls.Add(this.LBLC);
            this.groupBox2.Controls.Add(this.LBLB);
            this.groupBox2.Controls.Add(this.LBLA);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "E PARTİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "D PARTİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "C PARTİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "B PARTİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "A PARTİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "İLÇE AD:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(396, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(396, 77);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 25);
            this.progressBar1.TabIndex = 25;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(396, 132);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(257, 25);
            this.progressBar2.TabIndex = 26;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(396, 184);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(257, 25);
            this.progressBar3.TabIndex = 27;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(396, 237);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(257, 25);
            this.progressBar4.TabIndex = 28;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(396, 288);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(257, 25);
            this.progressBar5.TabIndex = 29;
            // 
            // LBLA
            // 
            this.LBLA.AutoSize = true;
            this.LBLA.Location = new System.Drawing.Point(679, 77);
            this.LBLA.Name = "LBLA";
            this.LBLA.Size = new System.Drawing.Size(24, 25);
            this.LBLA.TabIndex = 30;
            this.LBLA.Text = "0";
            // 
            // LBLB
            // 
            this.LBLB.AutoSize = true;
            this.LBLB.Location = new System.Drawing.Point(679, 132);
            this.LBLB.Name = "LBLB";
            this.LBLB.Size = new System.Drawing.Size(24, 25);
            this.LBLB.TabIndex = 31;
            this.LBLB.Text = "0";
            // 
            // LBLC
            // 
            this.LBLC.AutoSize = true;
            this.LBLC.Location = new System.Drawing.Point(679, 184);
            this.LBLC.Name = "LBLC";
            this.LBLC.Size = new System.Drawing.Size(24, 25);
            this.LBLC.TabIndex = 32;
            this.LBLC.Text = "0";
            // 
            // LBLD
            // 
            this.LBLD.AutoSize = true;
            this.LBLD.Location = new System.Drawing.Point(679, 237);
            this.LBLD.Name = "LBLD";
            this.LBLD.Size = new System.Drawing.Size(24, 25);
            this.LBLD.TabIndex = 33;
            this.LBLD.Text = "0";
            // 
            // LBLE
            // 
            this.LBLE.AutoSize = true;
            this.LBLE.Location = new System.Drawing.Point(679, 288);
            this.LBLE.Name = "LBLE";
            this.LBLE.Size = new System.Drawing.Size(24, 25);
            this.LBLE.TabIndex = 34;
            this.LBLE.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1220, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grafikler);
            this.Name = "FrmGrafikler";
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.grafikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLE;
        private System.Windows.Forms.Label LBLD;
        private System.Windows.Forms.Label LBLC;
        private System.Windows.Forms.Label LBLB;
        private System.Windows.Forms.Label LBLA;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}