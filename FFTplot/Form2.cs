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
    public partial class Form2 : Form
    {
        public Form2(double[] signal, int sampleFreq, int N)
        {
            InitializeComponent();

            for (var i = 0; i < N; ++i)
            {
                signalChart.Series["sample"].Points.AddXY(i, signal[i]);
            }

            FFT.OperationCount = 0;
            var spectrum = FFT.dft(signal, N);
            var operationCountDFT = FFT.OperationCount;

            FFT.OperationCount = 0;
            spectrum = FFT.fft54(signal);
            var operationCountFFT = FFT.OperationCount;

            var samplingStep = sampleFreq / (double)N;
            for (var i = 0; i < N/2; ++i)
            {
                spectrumChart.Series["harmonic"].Points.AddXY(i * samplingStep, spectrum[i].MAG/(N/2));
            }
            MessageBox.Show("Operation count with DFT: " + operationCountDFT + "\nOperation count with FFT: " + operationCountFFT + "\nCAC: " + operationCountDFT / (double)operationCountFFT);
        }
    }
}
