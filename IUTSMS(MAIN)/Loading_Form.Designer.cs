namespace IUTSMS_MAIN_
{
    partial class Loading_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Form));
            this.pbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.AnimationSpeed = 0.6F;
            this.pbar.BaseColor = System.Drawing.SystemColors.Control;
            this.pbar.Controls.Add(this.pictureBox1);
            this.pbar.IdleColor = System.Drawing.Color.DarkSeaGreen;
            this.pbar.IdleOffset = 20;
            this.pbar.Image = null;
            this.pbar.ImageSize = new System.Drawing.Size(52, 52);
            this.pbar.Location = new System.Drawing.Point(-1, 0);
            this.pbar.Name = "pbar";
            this.pbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pbar.ProgressOffset = 20;
            this.pbar.Size = new System.Drawing.Size(488, 458);
            this.pbar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 263);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loading_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 481);
            this.Controls.Add(this.pbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading_Form";
            this.Load += new System.EventHandler(this.Loading_Form_Load);
            this.pbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleProgressBar pbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}