using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Rate_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int baseSampleRate;
            int segmentLong;
            int segmentShort;
            float resampleValue;

            if (radioButtonBaseSR_44_1.Checked)
                baseSampleRate = 44100;
            else if (radioButtonBaseSR_88_2.Checked)
                baseSampleRate = 88200;
            else if (radioButtonBaseSR_176_4.Checked)
                baseSampleRate = 176400;
            else if (radioButtonBaseSR_48.Checked)
                baseSampleRate = 48000;
            else if (radioButtonBaseSR_96.Checked)
                baseSampleRate = 96000;
            else
                baseSampleRate = 192000;

            if (int.TryParse(segmentSamplesLong.Text, out segmentLong) &&
                segmentLong > 0)
            {
                if (int.TryParse(segmentSamplesShort.Text, out segmentShort) &&
                segmentShort > 0)
                {
                    if (radioButtonIncrease.Checked)
                    {
                        resampleValue = baseSampleRate + 
                            (baseSampleRate * ((segmentLong - segmentShort) / 
                            (float)segmentShort));
                    }
                    else
                    {
                        resampleValue = baseSampleRate -
                            (baseSampleRate * ((segmentLong - segmentShort) /
                            (float)segmentLong));
                    }
                    resampleValueOutput.Text = resampleValue.ToString("n2");
                }
                else
                {
                    MessageBox.Show("Invalid Short Segment input!\n\n" +
                       "Enter an integer sample count\n" + "value greater than 0",
                       "Invalid Input", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Long Segment input!\n\n" +
                   "Enter an integer sample count\n" + "value greater than 0",
                   "Invalid Input", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            segmentSamplesLong.Text = String.Empty;
            segmentSamplesShort.Text = String.Empty;
            resampleValueOutput.Text = String.Empty;
            radioButtonBaseSR_48.Checked = true;
            radioButtonIncrease.Checked = true;
        }
    }
}
