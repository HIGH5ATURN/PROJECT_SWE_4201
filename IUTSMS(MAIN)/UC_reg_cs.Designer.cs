namespace IUTSMS_MAIN_
{
    partial class UC_reg_cs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_reg_cs));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.Join_Button = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.pbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(422, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "JOIN IUTCS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Join_Button
            // 
            this.Join_Button.Animated = true;
            this.Join_Button.AnimationHoverSpeed = 0.07F;
            this.Join_Button.AnimationSpeed = 0.03F;
            this.Join_Button.BackColor = System.Drawing.Color.Transparent;
            this.Join_Button.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.Join_Button.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.Join_Button.BorderColor = System.Drawing.Color.Black;
            this.Join_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Join_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Join_Button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_Button.ForeColor = System.Drawing.Color.White;
            this.Join_Button.Image = null;
            this.Join_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.Join_Button.Location = new System.Drawing.Point(428, 497);
            this.Join_Button.Name = "Join_Button";
            this.Join_Button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.Join_Button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.Join_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Join_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.Join_Button.OnHoverImage = null;
            this.Join_Button.OnPressedColor = System.Drawing.Color.Black;
            this.Join_Button.Size = new System.Drawing.Size(266, 83);
            this.Join_Button.TabIndex = 14;
            this.Join_Button.Text = "JOIN";
            this.Join_Button.Click += new System.EventHandler(this.Join_Button_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(54, 49);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(254, 241);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 15;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(328, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seems like You are still not a member!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbar
            // 
            this.pbar.AnimationSpeed = 0.6F;
            this.pbar.BaseColor = System.Drawing.Color.White;
            this.pbar.Controls.Add(this.gunaCirclePictureBox1);
            this.pbar.IdleColor = System.Drawing.Color.Gainsboro;
            this.pbar.IdleOffset = 20;
            this.pbar.Image = null;
            this.pbar.ImageSize = new System.Drawing.Size(52, 52);
            this.pbar.Location = new System.Drawing.Point(386, 159);
            this.pbar.Name = "pbar";
            this.pbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pbar.ProgressOffset = 20;
            this.pbar.Size = new System.Drawing.Size(355, 332);
            this.pbar.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_reg_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Join_Button);
            this.Controls.Add(this.label2);
            this.Name = "UC_reg_cs";
            this.Size = new System.Drawing.Size(1152, 772);
            this.Load += new System.EventHandler(this.UC_reg_cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.pbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientTileButton Join_Button;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
    }
}
