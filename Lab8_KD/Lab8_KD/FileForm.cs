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
        public string[] fileItems; // To add to dialog box and send to player
        private string fileItem; // from dialog
        public int currInterval;
        private StreamReader streamReader;
        private StreamWriter streamWriter;
        public FileForm()
        {
            InitializeComponent();
        }
        private void addFile_Click(object sender, EventArgs e)
        {
            fileItem = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files (*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            fileItems = openFileDialog1.FileNames;
            // Loop through all files and add them
            for (int i = 0; i < fileItems.Length; i++)
            {
                fileItem = fileItems[i];
                currentFileBox.Items.Add(fileItem);
            }
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            if (currentFileBox.SelectedIndices.Count == 0)
            {
                return;
            }
            for (int i = currentFileBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                currentFileBox.Items.RemoveAt(currentFileBox.SelectedIndices[i]);
            }
        }

        private void openCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileItem = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = " Collection Files (*.pix)|*.pix|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFileBox.Items.Clear();
                streamReader = new StreamReader(openFileDialog1.OpenFile());
                int count = 0;
                while ((fileItem = streamReader.ReadLine()) != null)
                {
                    currentFileBox.Items.Add(fileItem);
                }

                streamReader.Close();
            }
        }

        private void saveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "*.pix|*.pix";
            if (currentFileBox.Items.Count == 0)
            {
                MessageBox.Show("No file names to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (fileItem != null)
            {
                saveFileDialog1.FileName = fileItem;
            }
            else
            {
                saveFileDialog1.FileName = null;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                streamWriter = new StreamWriter(saveFileDialog1.OpenFile());
                foreach (string valueAdd in currentFileBox.Items)
                {
                    streamWriter.WriteLine(valueAdd);
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

            if (currentFileBox.Items.Count == 0)
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
