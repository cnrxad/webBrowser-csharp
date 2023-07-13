using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

