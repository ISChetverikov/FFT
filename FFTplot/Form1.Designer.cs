namespace FFTplot
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSamplFreq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFreq2 = new System.Windows.Forms.TextBox();
            this.checkBoxFirst = new System.Windows.Forms.CheckBox();
            this.checkBoxSecond = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFreq1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAmp1 = new System.Windows.Forms.TextBox();
            this.textAmp2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonFFT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textSamples = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sampling Frequency, Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input data:";
            // 
            // textSamplFreq
            // 
            this.textSamplFreq.Location = new System.Drawing.Point(162, 188);
            this.textSamplFreq.Name = "textSamplFreq";
            this.textSamplFreq.Size = new System.Drawing.Size(75, 20);
            this.textSamplFreq.TabIndex = 2;
            this.textSamplFreq.Text = "5400";
            this.textSamplFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Frequency, Hz";
            // 
            // textFreq2
            // 
            this.textFreq2.Location = new System.Drawing.Point(116, 142);
            this.textFreq2.Name = "textFreq2";
            this.textFreq2.Size = new System.Drawing.Size(75, 20);
            this.textFreq2.TabIndex = 2;
            this.textFreq2.Text = "1000";
            this.textFreq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // checkBoxFirst
            // 
            this.checkBoxFirst.AutoSize = true;
            this.checkBoxFirst.Checked = true;
            this.checkBoxFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirst.Location = new System.Drawing.Point(37, 41);
            this.checkBoxFirst.Name = "checkBoxFirst";
            this.checkBoxFirst.Size = new System.Drawing.Size(88, 17);
            this.checkBoxFirst.TabIndex = 1;
            this.checkBoxFirst.Text = "first harmonic";
            this.checkBoxFirst.UseVisualStyleBackColor = true;
            // 
            // checkBoxSecond
            // 
            this.checkBoxSecond.AutoSize = true;
            this.checkBoxSecond.Location = new System.Drawing.Point(37, 113);
            this.checkBoxSecond.Name = "checkBoxSecond";
            this.checkBoxSecond.Size = new System.Drawing.Size(107, 17);
            this.checkBoxSecond.TabIndex = 1;
            this.checkBoxSecond.Text = "second harmonic";
            this.checkBoxSecond.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frequency, Hz";
            // 
            // textFreq1
            // 
            this.textFreq1.Location = new System.Drawing.Point(116, 69);
            this.textFreq1.Name = "textFreq1";
            this.textFreq1.Size = new System.Drawing.Size(75, 20);
            this.textFreq1.TabIndex = 2;
            this.textFreq1.Text = "1000";
            this.textFreq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amplitude";
            // 
            // textAmp1
            // 
            this.textAmp1.Location = new System.Drawing.Point(261, 69);
            this.textAmp1.Name = "textAmp1";
            this.textAmp1.Size = new System.Drawing.Size(75, 20);
            this.textAmp1.TabIndex = 2;
            this.textAmp1.Text = "5";
            this.textAmp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textAmp2
            // 
            this.textAmp2.Location = new System.Drawing.Point(261, 142);
            this.textAmp2.Name = "textAmp2";
            this.textAmp2.Size = new System.Drawing.Size(75, 20);
            this.textAmp2.TabIndex = 2;
            this.textAmp2.Text = "60";
            this.textAmp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amplitude";
            // 
            // buttonFFT
            // 
            this.buttonFFT.Location = new System.Drawing.Point(162, 267);
            this.buttonFFT.Name = "buttonFFT";
            this.buttonFFT.Size = new System.Drawing.Size(75, 23);
            this.buttonFFT.TabIndex = 3;
            this.buttonFFT.Text = "FFT";
            this.buttonFFT.UseVisualStyleBackColor = true;
            this.buttonFFT.Click += new System.EventHandler(this.buttonFFT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Samples Count";
            // 
            // textSamples
            // 
            this.textSamples.Location = new System.Drawing.Point(162, 228);
            this.textSamples.Name = "textSamples";
            this.textSamples.Size = new System.Drawing.Size(75, 20);
            this.textSamples.TabIndex = 2;
            this.textSamples.Text = "54";
            this.textSamples.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressOnSamplesInput);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(368, 302);
            this.Controls.Add(this.buttonFFT);
            this.Controls.Add(this.textAmp2);
            this.Controls.Add(this.textAmp1);
            this.Controls.Add(this.textSamples);
            this.Controls.Add(this.textSamplFreq);
            this.Controls.Add(this.textFreq2);
            this.Controls.Add(this.textFreq1);
            this.Controls.Add(this.checkBoxSecond);
            this.Controls.Add(this.checkBoxFirst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "54-point FFT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSamplFreq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFreq2;
        private System.Windows.Forms.CheckBox checkBoxFirst;
        private System.Windows.Forms.CheckBox checkBoxSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFreq1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAmp1;
        private System.Windows.Forms.TextBox textAmp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonFFT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSamples;

    }
}

