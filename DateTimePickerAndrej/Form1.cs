using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerAndrej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Vas datum leta je: \n" + dateTimePickerDatum.Value.ToShortDateString() + "\nVase vrijeme polaska je: \n" + dateTimePickerVrijeme.Value.ToShortTimeString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
