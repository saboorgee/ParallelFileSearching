namespace ParallelFileSearching
{
    partial class Form1
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.TextBoxfileNametoSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxException = new System.Windows.Forms.ListBox();
            this.textBoxFilePathtosearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(364, 66);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Start Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxfileNametoSearch
            // 
            this.TextBoxfileNametoSearch.Location = new System.Drawing.Point(118, 28);
            this.TextBoxfileNametoSearch.Name = "TextBoxfileNametoSearch";
            this.TextBoxfileNametoSearch.Size = new System.Drawing.Size(345, 20);
            this.TextBoxfileNametoSearch.TabIndex = 2;
            this.TextBoxfileNametoSearch.TextChanged += new System.EventHandler(this.TextBoxfileNametoSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter File to Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxShow);
            this.groupBox1.Location = new System.Drawing.Point(15, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 391);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBoxShow
            // 
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.Location = new System.Drawing.Point(14, 20);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.Size = new System.Drawing.Size(773, 355);
            this.listBoxShow.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBoxException);
            this.groupBox2.Location = new System.Drawing.Point(814, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 391);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxException";
            // 
            // listBoxException
            // 
            this.listBoxException.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxException.FormattingEnabled = true;
            this.listBoxException.Location = new System.Drawing.Point(14, 20);
            this.listBoxException.Name = "listBoxException";
            this.listBoxException.Size = new System.Drawing.Size(135, 355);
            this.listBoxException.TabIndex = 0;
            // 
            // textBoxFilePathtosearch
            // 
            this.textBoxFilePathtosearch.Location = new System.Drawing.Point(578, 27);
            this.textBoxFilePathtosearch.Name = "textBoxFilePathtosearch";
            this.textBoxFilePathtosearch.Size = new System.Drawing.Size(205, 20);
            this.textBoxFilePathtosearch.TabIndex = 6;
            this.textBoxFilePathtosearch.Text = "D:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 511);
            this.Controls.Add(this.textBoxFilePathtosearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxfileNametoSearch);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox TextBoxfileNametoSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxException;
        private System.Windows.Forms.TextBox textBoxFilePathtosearch;
        private System.Windows.Forms.Label label2;
    }
}

