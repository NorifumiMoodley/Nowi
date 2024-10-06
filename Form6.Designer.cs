namespace HomePage
{
	partial class Form6
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
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContactTxt
            // 
            this.ContactTxt.Location = new System.Drawing.Point(394, 367);
            this.ContactTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.Size = new System.Drawing.Size(132, 22);
            this.ContactTxt.TabIndex = 0;
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(394, 195);
            this.FNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(132, 22);
            this.FNameTxt.TabIndex = 1;
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(394, 280);
            this.LNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(132, 22);
            this.LNameTxt.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 631);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Teacher";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(394, 447);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(132, 22);
            this.usernametxt.TabIndex = 6;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(394, 546);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(132, 22);
            this.passwordtxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 512);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.FNameTxt);
            this.Controls.Add(this.ContactTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ContactTxt;
		private System.Windows.Forms.TextBox FNameTxt;
		private System.Windows.Forms.TextBox LNameTxt;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox usernametxt;
		private System.Windows.Forms.TextBox passwordtxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}