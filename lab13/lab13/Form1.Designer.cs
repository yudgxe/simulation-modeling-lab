namespace imit13
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BoolLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.AverageLbl = new System.Windows.Forms.Label();
            this.Chi2Lbl = new System.Windows.Forms.Label();
            this.VarianceLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Chi1Lbl = new System.Windows.Forms.Label();
            this.ErrAvgLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ErrVarLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.StatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Param1: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0.8";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numb of exp:";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(15, 69);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(161, 23);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(257, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(623, 321);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // StatPanel
            // 
            this.StatPanel.Controls.Add(this.label8);
            this.StatPanel.Controls.Add(this.BoolLbl);
            this.StatPanel.Controls.Add(this.label6);
            this.StatPanel.Controls.Add(this.label18);
            this.StatPanel.Controls.Add(this.AverageLbl);
            this.StatPanel.Controls.Add(this.Chi2Lbl);
            this.StatPanel.Controls.Add(this.VarianceLbl);
            this.StatPanel.Controls.Add(this.label16);
            this.StatPanel.Controls.Add(this.label10);
            this.StatPanel.Controls.Add(this.Chi1Lbl);
            this.StatPanel.Controls.Add(this.ErrAvgLbl);
            this.StatPanel.Controls.Add(this.label14);
            this.StatPanel.Controls.Add(this.label12);
            this.StatPanel.Controls.Add(this.ErrVarLbl);
            this.StatPanel.Location = new System.Drawing.Point(257, 369);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(601, 151);
            this.StatPanel.TabIndex = 28;
            this.StatPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Variance:";
            // 
            // BoolLbl
            // 
            this.BoolLbl.AutoSize = true;
            this.BoolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoolLbl.Location = new System.Drawing.Point(555, 117);
            this.BoolLbl.Name = "BoolLbl";
            this.BoolLbl.Size = new System.Drawing.Size(18, 20);
            this.BoolLbl.TabIndex = 26;
            this.BoolLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Average: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(502, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "is";
            // 
            // AverageLbl
            // 
            this.AverageLbl.AutoSize = true;
            this.AverageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageLbl.Location = new System.Drawing.Point(85, 12);
            this.AverageLbl.Name = "AverageLbl";
            this.AverageLbl.Size = new System.Drawing.Size(18, 20);
            this.AverageLbl.TabIndex = 14;
            this.AverageLbl.Text = "0";
            // 
            // Chi2Lbl
            // 
            this.Chi2Lbl.AutoSize = true;
            this.Chi2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chi2Lbl.Location = new System.Drawing.Point(438, 117);
            this.Chi2Lbl.Name = "Chi2Lbl";
            this.Chi2Lbl.Size = new System.Drawing.Size(18, 20);
            this.Chi2Lbl.TabIndex = 24;
            this.Chi2Lbl.Text = "0";
            // 
            // VarianceLbl
            // 
            this.VarianceLbl.AutoSize = true;
            this.VarianceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarianceLbl.Location = new System.Drawing.Point(85, 62);
            this.VarianceLbl.Name = "VarianceLbl";
            this.VarianceLbl.Size = new System.Drawing.Size(18, 20);
            this.VarianceLbl.TabIndex = 16;
            this.VarianceLbl.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(257, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Table numb of chi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(168, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Error = ";
            // 
            // Chi1Lbl
            // 
            this.Chi1Lbl.AutoSize = true;
            this.Chi1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chi1Lbl.Location = new System.Drawing.Point(142, 117);
            this.Chi1Lbl.Name = "Chi1Lbl";
            this.Chi1Lbl.Size = new System.Drawing.Size(18, 20);
            this.Chi1Lbl.TabIndex = 22;
            this.Chi1Lbl.Text = "0";
            // 
            // ErrAvgLbl
            // 
            this.ErrAvgLbl.AutoSize = true;
            this.ErrAvgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrAvgLbl.Location = new System.Drawing.Point(235, 12);
            this.ErrAvgLbl.Name = "ErrAvgLbl";
            this.ErrAvgLbl.Size = new System.Drawing.Size(18, 20);
            this.ErrAvgLbl.TabIndex = 18;
            this.ErrAvgLbl.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(15, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Chi-Squared:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(168, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Error = ";
            // 
            // ErrVarLbl
            // 
            this.ErrVarLbl.AutoSize = true;
            this.ErrVarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrVarLbl.Location = new System.Drawing.Point(235, 62);
            this.ErrVarLbl.Name = "ErrVarLbl";
            this.ErrVarLbl.Size = new System.Drawing.Size(18, 20);
            this.ErrVarLbl.TabIndex = 20;
            this.ErrVarLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 532);
            this.Controls.Add(this.StatPanel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.StatPanel.ResumeLayout(false);
            this.StatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel StatPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BoolLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label AverageLbl;
        private System.Windows.Forms.Label Chi2Lbl;
        private System.Windows.Forms.Label VarianceLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Chi1Lbl;
        private System.Windows.Forms.Label ErrAvgLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ErrVarLbl;
    }
}

