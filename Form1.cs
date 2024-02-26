using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_Tracker_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("l");
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("r");
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("n");
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("u");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
