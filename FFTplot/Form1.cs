using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFTplot
{
    public partial class Form1 : Form
    {
        double[] fillInputArray(double signalFrequency,double amp, int samplingFrequency, int dimension)
        {
            double[] result = new double[dimension];
            for (var i = 0; i < dimension; ++i)
            {
                result[i] = amp * Math.Sin(2 * Math.PI * signalFrequency * i / samplingFrequency );
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
 
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void textBox_KeyPressOnSamplesInput(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void buttonFFT_Click(object sender, EventArgs e)
        {
            var errorsString = "";
            const int DIMENSION = 54;
            var N = int.Parse(textSamples.Text);
            if (N >= DIMENSION) N = DIMENSION;

            var sampleFreq = int.Parse(textSamplFreq.Text);
            var isFirstHarmonicEnable = checkBoxFirst.Checked;
            var isSecondHarmonicEnable = checkBoxSecond.Checked;
           

            double[] signal = new double[DIMENSION];
            for (var i = 0; i < DIMENSION; ++i) signal[i] = 0;
            if (isFirstHarmonicEnable)
            {
                var freq = double.Parse(textFreq1.Text);
                var amp = double.Parse(textAmp1.Text);

                var harm = fillInputArray(freq, amp, sampleFreq, N);
                for (var i = 0; i < N; ++i) signal[i] += harm[i];
                
                
            }

            if (isSecondHarmonicEnable)
            {
                var freq = double.Parse(textFreq2.Text);
                var amp = double.Parse(textAmp2.Text);

                var harm = fillInputArray(freq, amp, sampleFreq, N);
                for (var i = 0; i < N; ++i) signal[i] += harm[i];
            }

            if (errorsString != "")
            {
                MessageBox.Show(errorsString, "Not valide data!");
                return;
            }

            var formPlot = new Form2(signal, sampleFreq, DIMENSION);
            formPlot.Show();
        }


    }
}
