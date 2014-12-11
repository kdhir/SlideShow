namespace Lab8_KD
{
    partial class FileForm
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
            this.currentFileBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteFile = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentFileBox
            // 
            this.currentFileBox.FormattingEnabled = true;
            this.currentFileBox.ItemHeight = 16;
            this.currentFileBox.Location = new System.Drawing.Point(12, 45);
            this.currentFileBox.Name = "currentFileBox";
            this.currentFileBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.currentFileBox.Size = new System.Drawing.Size(661, 84);
            this.currentFileBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteFile);
            this.groupBox1.Controls.Add(this.addFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // deleteFile
            // 
            this.deleteFile.Location = new System.Drawing.Point(189, 45);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(77, 37);
            this.deleteFile.TabIndex = 1;
            this.deleteFile.Text = "Delete";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(33, 45);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(77, 37);
            this.addFile.TabIndex = 0;
            this.addFile.Text = "Add";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(486, 191);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(107, 43);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interval";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCollectionToolStripMenuItem,
            this.saveCollectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCollectionToolStripMenuItem
            // 
            this.openCollectionToolStripMenuItem.Name = "openCollectionToolStripMenuItem";
            this.openCollectionToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.openCollectionToolStripMenuItem.Text = "Open Collection";
            this.openCollectionToolStripMenuItem.Click += new System.EventHandler(this.openCollectionToolStripMenuItem_Click);
            // 
            // saveCollectionToolStripMenuItem
            // 
            this.saveCollectionToolStripMenuItem.Name = "saveCollectionToolStripMenuItem";
            this.saveCollectionToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.saveCollectionToolStripMenuItem.Text = "Save Collection";
            this.saveCollectionToolStripMenuItem.Click += new System.EventHandler(this.saveCollectionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pix";
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(507, 256);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(100, 22);
            this.intervalBox.TabIndex = 6;
            this.intervalBox.Text = "5";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 321);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentFileBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileForm";
            this.Text = "File Form";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox currentFileBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox intervalBox;
    }
}

