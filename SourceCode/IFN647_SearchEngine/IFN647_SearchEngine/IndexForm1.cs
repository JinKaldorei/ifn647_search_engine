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
        private List<JournalArticle> articles;
        private LuceneSearch luceneSearch;
        public IndexForm1()
        {
            InitializeComponent();
            //test
            docPathLabel.Text = @"D:\collection\crandocs";
            indexPathLabel.Text = @"D:\ifn647_index";
            articles = new List<JournalArticle>();
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
                string documentPath = docPathLabel.Text;
                //Read all text file in document directory
                WalkDirectoryTree(documentPath);
                //Index
                IndexDocuments();

            } else
            {
                MessageBox.Show("Please specify document and index path.",
    "Important Note",
    MessageBoxButtons.OK,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
        }
        private void IndexDocuments()
        {
            textBox.AppendText("Start indexing ...\n");
            DateTime start = System.DateTime.Now;
            LuceneSearch luceneSearch = new LuceneSearch();

            string indexPath = indexPathLabel.Text;

            luceneSearch.CreateIndex(indexPath);
            System.Console.WriteLine("Adding Documents to Index");
            foreach (JournalArticle article in articles)
            {
                luceneSearch.IndexText(article.Words);
            }
            DateTime end = System.DateTime.Now;
            System.Console.WriteLine("All documents added.");
            textBox.AppendText("All documents added.\n");
            textBox.AppendText("The indexing lasted for "+(end -start)+"\n");
            nextBtn.Enabled = true;
        }
        private void WalkDirectoryTree(String path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder 
            try
            {
                files = root.GetFiles("*.txt");
            }

            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    string name = fi.FullName;
                    JournalArticle journalArticle = new JournalArticle(name);
                    articles.Add(journalArticle);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    string name = dirInfo.FullName;
                    WalkDirectoryTree(name);
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
