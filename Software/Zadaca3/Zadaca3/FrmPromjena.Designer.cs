namespace Zadaca3
{
    partial class FrmPromjena
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
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPromjeni = new System.Windows.Forms.Button();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtMeni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(138, 208);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID studenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID menija: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status: ";
            // 
            // btnPromjeni
            // 
            this.btnPromjeni.Location = new System.Drawing.Point(94, 268);
            this.btnPromjeni.Name = "btnPromjeni";
            this.btnPromjeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromjeni.TabIndex = 6;
            this.btnPromjeni.Text = "Promijeni";
            this.btnPromjeni.UseVisualStyleBackColor = true;
            this.btnPromjeni.Click += new System.EventHandler(this.btnPromjeni_Click);
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Location = new System.Drawing.Point(138, 147);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.Size = new System.Drawing.Size(119, 20);
            this.dtpVrijeme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vrijeme pripreme:";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(138, 31);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(119, 20);
            this.txtStudent.TabIndex = 9;
            // 
            // txtMeni
            // 
            this.txtMeni.Location = new System.Drawing.Point(138, 83);
            this.txtMeni.Name = "txtMeni";
            this.txtMeni.Size = new System.Drawing.Size(119, 20);
            this.txtMeni.TabIndex = 10;
            // 
            // FrmPromjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 325);
            this.Controls.Add(this.txtMeni);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.btnPromjeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPromjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena statusa";
            this.Load += new System.EventHandler(this.FrmPromjena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPromjeni;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.TextBox txtMeni;
    }
}