using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab8_KD
{
    public partial class FileForm : Form
    {
        public int currInterval;
        private string openFileName;
        public FileForm()
        {
            InitializeComponent();
        }
        private void addFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files (*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string[] fileNames = this.openFileDialog1.FileNames;
            string[] files = fileNames;
            for (int i = 0; i < files.Length; i++)
            {
                string item = files[i];
                this.currentFileBox.Items.Add(item);
            }
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            object[] files = new object[this.currentFileBox.SelectedItems.Count];
            this.currentFileBox.SelectedItems.CopyTo(files, 0);
            object[] updatedFiles = files;
            for (int i = 0; i < updatedFiles.Length; i++)
            {
                object value = updatedFiles[i];
                this.currentFileBox.Items.Remove(value);
            }
        }

        private void openCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = " Collection Files (*.pix)|*.pix|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.currentFileBox.Items.Clear();
                this.openFileName = this.openFileDialog1.FileName;
                StreamReader streamReader = new StreamReader(this.openFileDialog1.OpenFile());
                string item;
                while ((item = streamReader.ReadLine()) != null)
                {
                    this.currentFileBox.Items.Add(item);
                }
                streamReader.Close();
            }
        }

        private void saveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.currentFileBox.Items.Count == 0)
            {
                MessageBox.Show("No file names to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (this.openFileName != null)
            {
                this.saveFileDialog1.FileName = this.openFileName;
            }
            else
            {
                this.saveFileDialog1.FileName = null;
            }
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Image Files (*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                StreamWriter streamWriter = new StreamWriter(this.saveFileDialog1.OpenFile());
                foreach (string value in this.currentFileBox.Items)
                {
                    streamWriter.WriteLine(value);
                }
                streamWriter.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            if (this.currentFileBox.Items.Count == 0)
            {
                MessageBox.Show("No images to show.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                currInterval = Int32.Parse(intervalBox.Text);
                if (currInterval <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Please enter an integer time interval > 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            
            SlideForm slideForm = new SlideForm { Owner = this };
            slideForm.ShowDialog();
        }
    }
}
