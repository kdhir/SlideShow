namespace Lab8_KD
{
    partial class SlideForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SlideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SlideForm";
            this.Text = "Slide Form by Kanav Dhir";
            this.Load += new System.EventHandler(this.SlideForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SlideForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SlideForm_KeyDown);
            this.ResumeLayout(false);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}