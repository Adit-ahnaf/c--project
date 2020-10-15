namespace Bld_System
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
            this.n_ame = new System.Windows.Forms.TextBox();
            this.a_dress = new System.Windows.Forms.TextBox();
            this.b_loodgroup = new System.Windows.Forms.TextBox();
            this.p_hone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.regemail = new System.Windows.Forms.TextBox();
            this.regpassword = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n_ame
            // 
            this.n_ame.Location = new System.Drawing.Point(245, 50);
            this.n_ame.Name = "n_ame";
            this.n_ame.Size = new System.Drawing.Size(191, 26);
            this.n_ame.TabIndex = 0;
            // 
            // a_dress
            // 
            this.a_dress.Location = new System.Drawing.Point(245, 118);
            this.a_dress.Name = "a_dress";
            this.a_dress.Size = new System.Drawing.Size(191, 26);
            this.a_dress.TabIndex = 1;
            // 
            // b_loodgroup
            // 
            this.b_loodgroup.Location = new System.Drawing.Point(245, 181);
            this.b_loodgroup.Name = "b_loodgroup";
            this.b_loodgroup.Size = new System.Drawing.Size(191, 26);
            this.b_loodgroup.TabIndex = 2;
            // 
            // p_hone
            // 
            this.p_hone.Location = new System.Drawing.Point(245, 244);
            this.p_hone.Name = "p_hone";
            this.p_hone.Size = new System.Drawing.Size(191, 26);
            this.p_hone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "adress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "blood group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "phone";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // regemail
            // 
            this.regemail.Location = new System.Drawing.Point(245, 302);
            this.regemail.Name = "regemail";
            this.regemail.Size = new System.Drawing.Size(191, 26);
            this.regemail.TabIndex = 9;
            // 
            // regpassword
            // 
            this.regpassword.Location = new System.Drawing.Point(243, 360);
            this.regpassword.Name = "regpassword";
            this.regpassword.Size = new System.Drawing.Size(191, 26);
            this.regpassword.TabIndex = 10;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(160, 308);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 20);
            this.email.TabIndex = 11;
            this.email.Text = "email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "password";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(701, 566);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.regpassword);
            this.Controls.Add(this.regemail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p_hone);
            this.Controls.Add(this.b_loodgroup);
            this.Controls.Add(this.a_dress);
            this.Controls.Add(this.n_ame);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bloodgroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox n_ame;
        private System.Windows.Forms.TextBox a_dress;
        private System.Windows.Forms.TextBox b_loodgroup;
        private System.Windows.Forms.TextBox p_hone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox regemail;
        private System.Windows.Forms.TextBox regpassword;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label10;
    }
}

