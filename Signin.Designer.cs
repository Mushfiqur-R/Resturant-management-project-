namespace E_Project
{
    partial class Signin
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
            this.signinname = new System.Windows.Forms.Label();
            this.usernamesign = new System.Windows.Forms.Label();
            this.inputuser = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailleb = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.passwordsleb = new System.Windows.Forms.Label();
            this.consigbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinname
            // 
            this.signinname.AutoSize = true;
            this.signinname.Font = new System.Drawing.Font("Forte", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.signinname.Location = new System.Drawing.Point(169, 148);
            this.signinname.Name = "signinname";
            this.signinname.Size = new System.Drawing.Size(97, 32);
            this.signinname.TabIndex = 1;
            this.signinname.Text = "Signin";
            // 
            // usernamesign
            // 
            this.usernamesign.AutoSize = true;
            this.usernamesign.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.usernamesign.Location = new System.Drawing.Point(26, 210);
            this.usernamesign.Name = "usernamesign";
            this.usernamesign.Size = new System.Drawing.Size(129, 25);
            this.usernamesign.TabIndex = 2;
            this.usernamesign.Text = "Username :";
            // 
            // inputuser
            // 
            this.inputuser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputuser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputuser.ForeColor = System.Drawing.Color.Brown;
            this.inputuser.Location = new System.Drawing.Point(175, 201);
            this.inputuser.Multiline = true;
            this.inputuser.Name = "inputuser";
            this.inputuser.Size = new System.Drawing.Size(239, 43);
            this.inputuser.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Brown;
            this.textBox1.Location = new System.Drawing.Point(175, 273);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 43);
            this.textBox1.TabIndex = 4;
            // 
            // emailleb
            // 
            this.emailleb.AutoSize = true;
            this.emailleb.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailleb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.emailleb.Location = new System.Drawing.Point(26, 291);
            this.emailleb.Name = "emailleb";
            this.emailleb.Size = new System.Drawing.Size(94, 25);
            this.emailleb.TabIndex = 5;
            this.emailleb.Text = "Email :";
            // 
            // passwordbox
            // 
            this.passwordbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.ForeColor = System.Drawing.Color.Brown;
            this.passwordbox.Location = new System.Drawing.Point(175, 351);
            this.passwordbox.Multiline = true;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(239, 43);
            this.passwordbox.TabIndex = 6;
            // 
            // passwordsleb
            // 
            this.passwordsleb.AutoSize = true;
            this.passwordsleb.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordsleb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.passwordsleb.Location = new System.Drawing.Point(26, 369);
            this.passwordsleb.Name = "passwordsleb";
            this.passwordsleb.Size = new System.Drawing.Size(130, 25);
            this.passwordsleb.TabIndex = 7;
            this.passwordsleb.Text = "Password :";
            // 
            // consigbtn
            // 
            this.consigbtn.BackColor = System.Drawing.Color.Brown;
            this.consigbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consigbtn.ForeColor = System.Drawing.Color.White;
            this.consigbtn.Location = new System.Drawing.Point(326, 441);
            this.consigbtn.Name = "consigbtn";
            this.consigbtn.Size = new System.Drawing.Size(125, 51);
            this.consigbtn.TabIndex = 8;
            this.consigbtn.Text = "Confirm";
            this.consigbtn.UseVisualStyleBackColor = false;
            this.consigbtn.Click += new System.EventHandler(this.consigbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::E_Project.Properties.Resources.Login21;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(111, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 109);
            this.panel1.TabIndex = 0;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Brown;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(50, 441);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(125, 51);
            this.backbtn.TabIndex = 9;
            this.backbtn.Text = "<< Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 521);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.consigbtn);
            this.Controls.Add(this.passwordsleb);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.emailleb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputuser);
            this.Controls.Add(this.usernamesign);
            this.Controls.Add(this.signinname);
            this.Controls.Add(this.panel1);
            this.Name = "Signin";
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signinname;
        private System.Windows.Forms.Label usernamesign;
        private System.Windows.Forms.TextBox inputuser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label emailleb;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label passwordsleb;
        private System.Windows.Forms.Button consigbtn;
        private System.Windows.Forms.Button backbtn;
    }
}