namespace IUTSMS_MAIN_
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.admin_login_combobox = new Guna.UI.WinForms.GunaComboBox();
            this.login_pass_textBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.login_button = new Guna.UI.WinForms.GunaGradientTileButton();
            this.login_u_id_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.admin_back_Button = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gunaPictureBox2);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.admin_login_combobox);
            this.panel1.Controls.Add(this.login_pass_textBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.login_u_id_textBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 839);
            this.panel1.TabIndex = 0;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(851, 494);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(70, 65);
            this.gunaPictureBox2.TabIndex = 26;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(851, 386);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(70, 65);
            this.gunaPictureBox1.TabIndex = 25;
            this.gunaPictureBox1.TabStop = false;
            // 
            // admin_login_combobox
            // 
            this.admin_login_combobox.BackColor = System.Drawing.Color.Transparent;
            this.admin_login_combobox.BaseColor = System.Drawing.SystemColors.Control;
            this.admin_login_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.admin_login_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.admin_login_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admin_login_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.admin_login_combobox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_combobox.ForeColor = System.Drawing.Color.Black;
            this.admin_login_combobox.FormattingEnabled = true;
            this.admin_login_combobox.Items.AddRange(new object[] {
            "IUTCS",
            "IUTDS",
            "IUTPS",
            "IUTSIKS"});
            this.admin_login_combobox.Location = new System.Drawing.Point(930, 312);
            this.admin_login_combobox.Name = "admin_login_combobox";
            this.admin_login_combobox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.admin_login_combobox.OnHoverItemForeColor = System.Drawing.SystemColors.Control;
            this.admin_login_combobox.Radius = 10;
            this.admin_login_combobox.Size = new System.Drawing.Size(373, 39);
            this.admin_login_combobox.TabIndex = 24;
            // 
            // login_pass_textBox
            // 
            this.login_pass_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.login_pass_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_pass_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pass_textBox.Location = new System.Drawing.Point(927, 525);
            this.login_pass_textBox.Name = "login_pass_textBox";
            this.login_pass_textBox.Size = new System.Drawing.Size(373, 31);
            this.login_pass_textBox.TabIndex = 21;
            this.login_pass_textBox.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(605, 850);
            this.panel4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "WELCOME\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(232, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 250);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "To \r\nIUT Society Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 259);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.panel3.Location = new System.Drawing.Point(927, 558);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 1);
            this.panel3.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1144, 579);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 32);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_button
            // 
            this.login_button.Animated = true;
            this.login_button.AnimationHoverSpeed = 0.07F;
            this.login_button.AnimationSpeed = 0.03F;
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.login_button.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.login_button.BorderColor = System.Drawing.Color.Black;
            this.login_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login_button.FocusedColor = System.Drawing.Color.Empty;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Image = null;
            this.login_button.ImageSize = new System.Drawing.Size(52, 52);
            this.login_button.Location = new System.Drawing.Point(924, 642);
            this.login_button.Name = "login_button";
            this.login_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.login_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.login_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_button.OnHoverForeColor = System.Drawing.Color.White;
            this.login_button.OnHoverImage = null;
            this.login_button.OnPressedColor = System.Drawing.Color.Black;
            this.login_button.Radius = 30;
            this.login_button.Size = new System.Drawing.Size(376, 123);
            this.login_button.TabIndex = 22;
            this.login_button.Text = "LOGIN";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_u_id_textBox
            // 
            this.login_u_id_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.login_u_id_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_u_id_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_u_id_textBox.Location = new System.Drawing.Point(930, 417);
            this.login_u_id_textBox.Name = "login_u_id_textBox";
            this.login_u_id_textBox.Size = new System.Drawing.Size(373, 31);
            this.login_u_id_textBox.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.panel2.Location = new System.Drawing.Point(927, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 1);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(1013, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 71);
            this.label2.TabIndex = 17;
            this.label2.Text = "LOGIN\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.Animated = true;
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1411, -4);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(47, 44);
            this.gunaControlBox2.TabIndex = 6;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1458, -4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(41, 44);
            this.gunaControlBox1.TabIndex = 5;
            // 
            // admin_back_Button
            // 
            this.admin_back_Button.Animated = true;
            this.admin_back_Button.AnimationHoverSpeed = 0.07F;
            this.admin_back_Button.AnimationSpeed = 0.03F;
            this.admin_back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.admin_back_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.admin_back_Button.BorderColor = System.Drawing.Color.Black;
            this.admin_back_Button.BorderSize = 1;
            this.admin_back_Button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.admin_back_Button.CheckedBorderColor = System.Drawing.Color.Black;
            this.admin_back_Button.CheckedForeColor = System.Drawing.Color.White;
            this.admin_back_Button.CheckedImage = null;
            this.admin_back_Button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.admin_back_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.admin_back_Button.FocusedColor = System.Drawing.Color.Empty;
            this.admin_back_Button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_back_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.admin_back_Button.Image = null;
            this.admin_back_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.admin_back_Button.LineColor = System.Drawing.Color.Red;
            this.admin_back_Button.Location = new System.Drawing.Point(0, -4);
            this.admin_back_Button.Name = "admin_back_Button";
            this.admin_back_Button.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.admin_back_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.admin_back_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.admin_back_Button.OnHoverImage = null;
            this.admin_back_Button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.admin_back_Button.OnPressedColor = System.Drawing.Color.Black;
            this.admin_back_Button.Size = new System.Drawing.Size(605, 51);
            this.admin_back_Button.TabIndex = 1;
            this.admin_back_Button.Text = "Go back";
            this.admin_back_Button.Click += new System.EventHandler(this.admin_back_Button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(988, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(282, 181);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1498, 874);
            this.Controls.Add(this.admin_back_Button);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Admin_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Admin_Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Admin_Form_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaAdvenceTileButton admin_back_Button;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaComboBox admin_login_combobox;
        private System.Windows.Forms.TextBox login_pass_textBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI.WinForms.GunaGradientTileButton login_button;
        private System.Windows.Forms.TextBox login_u_id_textBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}