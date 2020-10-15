namespace Bld_System
{
    partial class Option
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
            this.donateblood = new System.Windows.Forms.Button();
            this.requestblood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.bloodgroup = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // donateblood
            // 
            this.donateblood.Location = new System.Drawing.Point(56, 472);
            this.donateblood.Name = "donateblood";
            this.donateblood.Size = new System.Drawing.Size(167, 61);
            this.donateblood.TabIndex = 0;
            this.donateblood.Text = "Donate Blood";
            this.donateblood.UseVisualStyleBackColor = true;
            this.donateblood.Click += new System.EventHandler(this.donateblood_Click);
            // 
            // requestblood
            // 
            this.requestblood.Location = new System.Drawing.Point(265, 472);
            this.requestblood.Name = "requestblood";
            this.requestblood.Size = new System.Drawing.Size(212, 61);
            this.requestblood.TabIndex = 1;
            this.requestblood.Text = "Request Blood";
            this.requestblood.UseVisualStyleBackColor = true;
            this.requestblood.Click += new System.EventHandler(this.requestblood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADRESS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "BLOOD GROUP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "PHONE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "EMAIL :";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(215, 357);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(141, 58);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(251, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(203, 26);
            this.name.TabIndex = 14;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(251, 129);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(203, 26);
            this.adress.TabIndex = 15;
            // 
            // bloodgroup
            // 
            this.bloodgroup.Location = new System.Drawing.Point(251, 182);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(203, 26);
            this.bloodgroup.TabIndex = 16;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(251, 230);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(203, 26);
            this.phone.TabIndex = 17;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(251, 281);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(203, 26);
            this.email.TabIndex = 18;
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 599);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.bloodgroup);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestblood);
            this.Controls.Add(this.donateblood);
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button donateblood;
        private System.Windows.Forms.Button requestblood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox bloodgroup;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox email;
    }
}