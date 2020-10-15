namespace Bld_System
{
    partial class Donordata
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchbloodgroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.bloodgroup = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(685, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchbloodgroup
            // 
            this.searchbloodgroup.Location = new System.Drawing.Point(195, 50);
            this.searchbloodgroup.Name = "searchbloodgroup";
            this.searchbloodgroup.Size = new System.Drawing.Size(326, 26);
            this.searchbloodgroup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Blood Group Bellow";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(549, 48);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 31);
            this.search.TabIndex = 3;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(855, 107);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(855, 180);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(59, 20);
            this.adress.TabIndex = 5;
            this.adress.Text = "Adress";
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSize = true;
            this.bloodgroup.Location = new System.Drawing.Point(855, 262);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(99, 20);
            this.bloodgroup.TabIndex = 6;
            this.bloodgroup.Text = "Blood Group";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(855, 342);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(55, 20);
            this.phone.TabIndex = 7;
            this.phone.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Donordata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.bloodgroup);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbloodgroup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Donordata";
            this.Text = "Donordata";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchbloodgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label bloodgroup;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button button1;
    }
}