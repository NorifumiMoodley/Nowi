namespace CtrlFreaks_SignUp_LogIn
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.vidBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.PwsdTxt = new System.Windows.Forms.TextBox();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.Pswdlbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.SignUpLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.vidBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.PwsdTxt);
            this.panel1.Controls.Add(this.LNameTxt);
            this.panel1.Controls.Add(this.FNameTxt);
            this.panel1.Controls.Add(this.UsernameTxt);
            this.panel1.Controls.Add(this.Pswdlbl);
            this.panel1.Controls.Add(this.SurnameLbl);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.UsernameLbl);
            this.panel1.Controls.Add(this.SignUpLbl);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Location = new System.Drawing.Point(609, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 279);
            this.panel2.TabIndex = 15;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(4, 4);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(297, 259);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // vidBtn
            // 
            this.vidBtn.Location = new System.Drawing.Point(708, 322);
            this.vidBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vidBtn.Name = "vidBtn";
            this.vidBtn.Size = new System.Drawing.Size(100, 28);
            this.vidBtn.TabIndex = 13;
            this.vidBtn.Text = "click me";
            this.vidBtn.UseVisualStyleBackColor = true;
            this.vidBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.label1.Location = new System.Drawing.Point(475, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Already have an account, go";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.linkLabel1.Location = new System.Drawing.Point(773, 551);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 28);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back to Log In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(644, 411);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 94);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PwsdTxt
            // 
            this.PwsdTxt.BackColor = System.Drawing.SystemColors.Window;
            this.PwsdTxt.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.PwsdTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PwsdTxt.Location = new System.Drawing.Point(77, 485);
            this.PwsdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PwsdTxt.Name = "PwsdTxt";
            this.PwsdTxt.Size = new System.Drawing.Size(505, 36);
            this.PwsdTxt.TabIndex = 8;
            this.PwsdTxt.Text = "Enter Password";
            this.PwsdTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.PwsdTxt.Enter += new System.EventHandler(this.PwsdTxt_Enter);
            this.PwsdTxt.Leave += new System.EventHandler(this.PwsdTxt_Leave);
            // 
            // LNameTxt
            // 
            this.LNameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.LNameTxt.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.LNameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LNameTxt.Location = new System.Drawing.Point(77, 374);
            this.LNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(505, 36);
            this.LNameTxt.TabIndex = 7;
            this.LNameTxt.Text = "Enter Surname";
            this.LNameTxt.Enter += new System.EventHandler(this.LNameTxt_Enter);
            this.LNameTxt.Leave += new System.EventHandler(this.LNameTxt_Leave);
            // 
            // FNameTxt
            // 
            this.FNameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.FNameTxt.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.FNameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FNameTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FNameTxt.Location = new System.Drawing.Point(77, 256);
            this.FNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(505, 36);
            this.FNameTxt.TabIndex = 6;
            this.FNameTxt.Text = "Enter Name";
            this.FNameTxt.Enter += new System.EventHandler(this.FNameTxt_Enter);
            this.FNameTxt.Leave += new System.EventHandler(this.FNameTxt_Leave);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.UsernameTxt.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsernameTxt.Location = new System.Drawing.Point(77, 146);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(505, 36);
            this.UsernameTxt.TabIndex = 5;
            this.UsernameTxt.Text = "Enter Username\r\n";
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            this.UsernameTxt.Enter += new System.EventHandler(this.UsernameTxt_Enter);
            this.UsernameTxt.Leave += new System.EventHandler(this.UsernameTxt_Leave);
            // 
            // Pswdlbl
            // 
            this.Pswdlbl.AutoSize = true;
            this.Pswdlbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.Pswdlbl.Location = new System.Drawing.Point(73, 458);
            this.Pswdlbl.Name = "Pswdlbl";
            this.Pswdlbl.Size = new System.Drawing.Size(89, 24);
            this.Pswdlbl.TabIndex = 4;
            this.Pswdlbl.Text = "Password";
            this.Pswdlbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.SurnameLbl.Location = new System.Drawing.Point(73, 347);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(84, 24);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Surname";
            this.SurnameLbl.Click += new System.EventHandler(this.SurnameLbl_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.NameLbl.Location = new System.Drawing.Point(73, 229);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(100, 24);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "First Name";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(73, 119);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(95, 24);
            this.UsernameLbl.TabIndex = 1;
            this.UsernameLbl.Text = "Username";
            // 
            // SignUpLbl
            // 
            this.SignUpLbl.AutoSize = true;
            this.SignUpLbl.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLbl.ForeColor = System.Drawing.Color.Red;
            this.SignUpLbl.Location = new System.Drawing.Point(381, 34);
            this.SignUpLbl.Name = "SignUpLbl";
            this.SignUpLbl.Size = new System.Drawing.Size(136, 45);
            this.SignUpLbl.TabIndex = 0;
            this.SignUpLbl.Text = "Sign Up";
            this.SignUpLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(978, 949);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Pswdlbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label SignUpLbl;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PwsdTxt;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button vidBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

