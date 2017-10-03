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
    public partial class MainForm : Form
    {
        public LuceneSearch LuceneSearch { get; private set; } 
        public MainForm(LuceneSearch luceneSearch)
        {
            InitializeComponent();
            LuceneSearch = luceneSearch;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
