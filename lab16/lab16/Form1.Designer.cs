namespace lab4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStocks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.inputDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRun = new System.Windows.Forms.Button();
            this.btSell = new System.Windows.Forms.Button();
            this.btBuy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btPlay = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPause);
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Controls.Add(this.lbStocks);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.inputDays);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btRun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbStocks
            // 
            this.lbStocks.AutoSize = true;
            this.lbStocks.Location = new System.Drawing.Point(576, 29);
            this.lbStocks.Name = "lbStocks";
            this.lbStocks.Size = new System.Drawing.Size(13, 13);
            this.lbStocks.TabIndex = 8;
            this.lbStocks.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stocks:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(576, 9);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(43, 13);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "10000$";
            // 
            // inputDays
            // 
            this.inputDays.Location = new System.Drawing.Point(12, 64);
            this.inputDays.Name = "inputDays";
            this.inputDays.Size = new System.Drawing.Size(100, 20);
            this.inputDays.TabIndex = 4;
            this.inputDays.Text = "10";
            this.inputDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money:";
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(12, 25);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(100, 20);
            this.inputPrice.TabIndex = 2;
            this.inputPrice.Text = "73,0783";
            this.inputPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial price";
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(143, 25);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 20);
            this.btRun.TabIndex = 0;
            this.btRun.Text = "Start";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btSell
            // 
            this.btSell.Location = new System.Drawing.Point(620, 237);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(75, 23);
            this.btSell.TabIndex = 6;
            this.btSell.Text = "Sell";
            this.btSell.UseVisualStyleBackColor = true;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(620, 208);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(75, 23);
            this.btBuy.TabIndex = 5;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.LabelStyle.Format = "f4";
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.DarkGreen;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(722, 321);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(620, 64);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 20);
            this.btPlay.TabIndex = 9;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(534, 64);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(75, 20);
            this.btPause.TabIndex = 10;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 421);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.btSell);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStocks;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btPlay;
    }
}

