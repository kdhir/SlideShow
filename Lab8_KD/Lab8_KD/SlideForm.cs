using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_KD
{
    public partial class SlideForm : Form
    {
        private int currSlide = 0;
        private string currentFileItem;
        private Image currImage;
        private SizeF clientSize;
        private int currImageWidth, currImageHeight;
        private float centering; // to center the image
        private Font font = new Font("Arial", 30);
        private Brush brush = Brushes.Green;
        private FileForm controller;
        Graphics graphics;
        public SlideForm()
        {
            InitializeComponent();
        }

        private void SlideForm_Load(object sender, EventArgs e)
        {
            controller = (FileForm)base.Owner;
            timer1.Interval = controller.currInterval * 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.currSlide++;
            base.Invalidate();
        }
        //Exit Viewer
        private void SlideForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) base.DialogResult = DialogResult.OK;
        }

        private void SlideForm_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;

            if (currSlide > controller.currentFileBox.Items.Count - 1) // check for finished slideshow
            {
                DialogResult = DialogResult.OK;
                return;
            }

            currentFileItem = (string)controller.currentFileBox.Items[currSlide]; // get the file in the idex of current slide
            try
            {
                currImage = Image.FromFile(currentFileItem);
                clientSize = ClientSize;
                currImageHeight = currImage.Height;
                currImageWidth = currImage.Width;
                // centering padding calculation
                centering = Math.Min(clientSize.Height / (float)currImageHeight, clientSize.Width / (float)currImageWidth);
                // place image
                graphics.DrawImage(currImage, (clientSize.Width - (float)currImageWidth * centering) / 2f, (clientSize.Height - (float)currImageHeight * centering) / 2f, (float)currImageWidth * centering, (float)currImageHeight * centering);
            }
            catch
            {
                graphics.DrawString("Not an image file!", font, brush, 25, 25);
            } 
        }
    }
}
