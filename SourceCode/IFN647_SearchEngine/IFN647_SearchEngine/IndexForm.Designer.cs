namespace IFN647_SearchEngine
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.docPathLabel = new System.Windows.Forms.Label();
            this.indexPathLabel = new System.Windows.Forms.Label();
            this.documentPathBtn = new System.Windows.Forms.Button();
            this.indexPathBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.indexBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index Directory:";
            // 
            // docPathLabel
            // 
            this.docPathLabel.AutoSize = true;
            this.docPathLabel.Location = new System.Drawing.Point(124, 48);
            this.docPathLabel.Name = "docPathLabel";
            this.docPathLabel.Size = new System.Drawing.Size(0, 13);
            this.docPathLabel.TabIndex = 2;
            // 
            // indexPathLabel
            // 
            this.indexPathLabel.AutoSize = true;
            this.indexPathLabel.Location = new System.Drawing.Point(100, 77);
            this.indexPathLabel.Name = "indexPathLabel";
            this.indexPathLabel.Size = new System.Drawing.Size(0, 13);
            this.indexPathLabel.TabIndex = 3;
            // 
            // documentPathBtn
            // 
            this.documentPathBtn.Location = new System.Drawing.Point(387, 43);
            this.documentPathBtn.Name = "documentPathBtn";
            this.documentPathBtn.Size = new System.Drawing.Size(75, 23);
            this.documentPathBtn.TabIndex = 4;
            this.documentPathBtn.Text = "Browse";
            this.documentPathBtn.UseVisualStyleBackColor = true;
            this.documentPathBtn.Click += new System.EventHandler(this.documentPathBtn_Click);
            // 
            // indexPathBtn
            // 
            this.indexPathBtn.Location = new System.Drawing.Point(387, 77);
            this.indexPathBtn.Name = "indexPathBtn";
            this.indexPathBtn.Size = new System.Drawing.Size(75, 23);
            this.indexPathBtn.TabIndex = 5;
            this.indexPathBtn.Text = "Browse";
            this.indexPathBtn.UseVisualStyleBackColor = true;
            this.indexPathBtn.Click += new System.EventHandler(this.indexPathBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 132);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(274, 222);
            this.textBox.TabIndex = 6;
            // 
            // indexBtn
            // 
            this.indexBtn.Location = new System.Drawing.Point(387, 132);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(75, 23);
            this.indexBtn.TabIndex = 7;
            this.indexBtn.Text = "Index";
            this.indexBtn.UseVisualStyleBackColor = true;
            this.indexBtn.Click += new System.EventHandler(this.indexBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(387, 174);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "Start";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // IndexForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 366);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.indexBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.indexPathBtn);
            this.Controls.Add(this.documentPathBtn);
            this.Controls.Add(this.indexPathLabel);
            this.Controls.Add(this.docPathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IndexForm1";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label docPathLabel;
        private System.Windows.Forms.Label indexPathLabel;
        private System.Windows.Forms.Button documentPathBtn;
        private System.Windows.Forms.Button indexPathBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button indexBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

