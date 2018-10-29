using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmAnalysis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSink_Click(object sender, EventArgs e)
        {
            textBoxFinished.Text = "";

            Tools.SinkingSort();
            textBoxFinished.Text = "Finished";
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            textBoxFinished.Text = "";

            Tools.SelectionSort();
            textBoxFinished.Text = "Finished";
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            textBoxFinished.Text = "";

            Tools.MergeSort(Tools.CreateArray(100));
            textBoxFinished.Text = "Finished";

        }

        private void buttonMedianQuickSort_Click(object sender, EventArgs e)
        {
            textBoxFinished.Text = "";
            Tools.MedianQuickSort(Tools.CreateArray(100));
            textBoxFinished.Text = "Finished";
        }

        private void buttonOGQuickSort_Click(object sender, EventArgs e)
        {
            textBoxFinished.Text = "";
            Tools.OriginalQuickSort(Tools.CreateArray(100));
            textBoxFinished.Text = "Finished";
        }
    }
}
