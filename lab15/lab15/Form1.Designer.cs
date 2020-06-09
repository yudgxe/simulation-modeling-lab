namespace lab15
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.DayCountLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SunnyLab = new System.Windows.Forms.Label();
            this.CloudyLab = new System.Windows.Forms.Label();
            this.RainLab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StateLab = new System.Windows.Forms.Label();
            this.WeatherLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DayCountLab
            // 
            this.DayCountLab.AutoSize = true;
            this.DayCountLab.Location = new System.Drawing.Point(49, 9);
            this.DayCountLab.Name = "DayCountLab";
            this.DayCountLab.Size = new System.Drawing.Size(13, 13);
            this.DayCountLab.TabIndex = 1;
            this.DayCountLab.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cloudy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sunny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rain";
            // 
            // SunnyLab
            // 
            this.SunnyLab.AutoSize = true;
            this.SunnyLab.Location = new System.Drawing.Point(205, 52);
            this.SunnyLab.Name = "SunnyLab";
            this.SunnyLab.Size = new System.Drawing.Size(13, 13);
            this.SunnyLab.TabIndex = 6;
            this.SunnyLab.Text = "0";
            // 
            // CloudyLab
            // 
            this.CloudyLab.AutoSize = true;
            this.CloudyLab.Location = new System.Drawing.Point(205, 65);
            this.CloudyLab.Name = "CloudyLab";
            this.CloudyLab.Size = new System.Drawing.Size(13, 13);
            this.CloudyLab.TabIndex = 7;
            this.CloudyLab.Text = "0";
            // 
            // RainLab
            // 
            this.RainLab.AutoSize = true;
            this.RainLab.Location = new System.Drawing.Point(205, 78);
            this.RainLab.Name = "RainLab";
            this.RainLab.Size = new System.Drawing.Size(13, 13);
            this.RainLab.TabIndex = 8;
            this.RainLab.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Days:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Now:";
            // 
            // StateLab
            // 
            this.StateLab.AutoSize = true;
            this.StateLab.Location = new System.Drawing.Point(49, 22);
            this.StateLab.Name = "StateLab";
            this.StateLab.Size = new System.Drawing.Size(32, 13);
            this.StateLab.TabIndex = 11;
            this.StateLab.Text = "State";
            // 
            // WeatherLab
            // 
            this.WeatherLab.AutoSize = true;
            this.WeatherLab.Location = new System.Drawing.Point(49, 35);
            this.WeatherLab.Name = "WeatherLab";
            this.WeatherLab.Size = new System.Drawing.Size(48, 13);
            this.WeatherLab.TabIndex = 12;
            this.WeatherLab.Text = "Weather";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 101);
            this.Controls.Add(this.WeatherLab);
            this.Controls.Add(this.StateLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RainLab);
            this.Controls.Add(this.CloudyLab);
            this.Controls.Add(this.SunnyLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayCountLab);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DayCountLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SunnyLab;
        private System.Windows.Forms.Label CloudyLab;
        private System.Windows.Forms.Label RainLab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StateLab;
        private System.Windows.Forms.Label WeatherLab;
    }
}

