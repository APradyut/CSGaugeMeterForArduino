namespace Gauge
{
    partial class Form1
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            this.meter = new System.Windows.Forms.AGauge();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meter
            // 
            this.meter.BaseArcColor = System.Drawing.Color.Gray;
            this.meter.BaseArcRadius = 80;
            this.meter.BaseArcStart = 135;
            this.meter.BaseArcSweep = 270;
            this.meter.BaseArcWidth = 2;
            this.meter.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(90, 130);
            aGaugeLabel1.Text = "Km/h";
            aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel2.Name = "GaugeLabel2";
            aGaugeLabel2.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel2.Text = null;
            this.meter.GaugeLabels.Add(aGaugeLabel1);
            this.meter.GaugeLabels.Add(aGaugeLabel2);
            this.meter.Location = new System.Drawing.Point(47, 44);
            this.meter.MaxValue = 400F;
            this.meter.MinValue = 0F;
            this.meter.Name = "meter";
            this.meter.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.meter.NeedleColor2 = System.Drawing.Color.DimGray;
            this.meter.NeedleRadius = 70;
            this.meter.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.meter.NeedleWidth = 5;
            this.meter.ScaleLinesInterColor = System.Drawing.Color.Maroon;
            this.meter.ScaleLinesInterInnerRadius = 73;
            this.meter.ScaleLinesInterOuterRadius = 80;
            this.meter.ScaleLinesInterWidth = 1;
            this.meter.ScaleLinesMajorColor = System.Drawing.Color.OrangeRed;
            this.meter.ScaleLinesMajorInnerRadius = 70;
            this.meter.ScaleLinesMajorOuterRadius = 80;
            this.meter.ScaleLinesMajorStepValue = 50F;
            this.meter.ScaleLinesMajorWidth = 2;
            this.meter.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.meter.ScaleLinesMinorInnerRadius = 75;
            this.meter.ScaleLinesMinorOuterRadius = 80;
            this.meter.ScaleLinesMinorTicks = 9;
            this.meter.ScaleLinesMinorWidth = 1;
            this.meter.ScaleNumbersColor = System.Drawing.Color.Black;
            this.meter.ScaleNumbersFormat = null;
            this.meter.ScaleNumbersRadius = 95;
            this.meter.ScaleNumbersRotation = 0;
            this.meter.ScaleNumbersStartScaleLine = 0;
            this.meter.ScaleNumbersStepScaleLines = 1;
            this.meter.Size = new System.Drawing.Size(217, 183);
            this.meter.TabIndex = 0;
            this.meter.Text = "Speed-o-meter";
            this.meter.Value = 0F;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.meter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.AGauge meter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

