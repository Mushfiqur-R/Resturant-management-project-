namespace E_Project
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
            this.signInForm = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordlab = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInForm
            // 
            this.signInForm.BackColor = System.Drawing.Color.Red;
            this.signInForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signInForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInForm.Location = new System.Drawing.Point(570, 433);
            this.signInForm.Name = "signInForm";
            this.signInForm.Size = new System.Drawing.Size(161, 42);
            this.signInForm.TabIndex = 0;
            this.signInForm.Text = "SignIn";
            this.signInForm.UseVisualStyleBackColor = false;
            this.signInForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.AutoSize = true;
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Loginbtn.Location = new System.Drawing.Point(103, 235);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(91, 42);
            this.Loginbtn.TabIndex = 1;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordlab);
            this.groupBox1.Controls.Add(this.userlabel);
            this.groupBox1.Controls.Add(this.Loginbtn);
            this.groupBox1.Controls.Add(this.passwordbox);
            this.groupBox1.Controls.Add(this.usernametext);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(449, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // passwordlab
            // 
            this.passwordlab.AutoSize = true;
            this.passwordlab.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.passwordlab.Location = new System.Drawing.Point(57, 150);
            this.passwordlab.Name = "passwordlab";
            this.passwordlab.Size = new System.Drawing.Size(103, 20);
            this.passwordlab.TabIndex = 9;
            this.passwordlab.Text = "Password :";
            this.passwordlab.Click += new System.EventHandler(this.passwordlab_Click);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.Firebrick;
            this.userlabel.Location = new System.Drawing.Point(54, 69);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(104, 20);
            this.userlabel.TabIndex = 8;
            this.userlabel.Text = "Username :";
            // 
            // passwordbox
            // 
            this.passwordbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordbox.Location = new System.Drawing.Point(61, 184);
            this.passwordbox.Multiline = true;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(215, 33);
            this.passwordbox.TabIndex = 7;
            // 
            // usernametext
            // 
            this.usernametext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usernametext.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.Location = new System.Drawing.Point(58, 102);
            this.usernametext.Multiline = true;
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(224, 33);
            this.usernametext.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(585, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t Sign in yet?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(74, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = " FusionFlare Dining";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImage = global::E_Project.Properties.Resources.Login2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(54, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 302);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(867, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.signInForm);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInForm;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label passwordlab;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

