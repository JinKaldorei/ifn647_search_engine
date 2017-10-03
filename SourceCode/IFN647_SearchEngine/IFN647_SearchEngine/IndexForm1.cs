using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFN647_SearchEngine
{
    public partial class IndexForm1 : Form
    {
        public IndexForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void documentPathBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                docPathLabel.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void indexPathBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                indexPathLabel.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void indexBtn_Click(object sender, EventArgs e)
        {
            if (docPathLabel.Text !="" && indexPathLabel.Text !="")
            {

            } else
            {
                MessageBox.Show("Please specify document and index path.",
    "Important Note",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
