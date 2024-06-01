namespace Zadaca3
{
    partial class FrmDodavanje
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
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKupon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtMeni = new System.Windows.Forms.TextBox();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.Vrijeme = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(454, 97);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 3;
            // 
            // txtKupon
            // 
            this.txtKupon.Location = new System.Drawing.Point(454, 207);
            this.txtKupon.Name = "txtKupon";
            this.txtKupon.Size = new System.Drawing.Size(100, 20);
            this.txtKupon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "lD studenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID menija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrijeme pripreme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(454, 155);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 21);
            this.cboStatus.TabIndex = 12;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Iskoristen kupon:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(245, 320);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 41);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID zaposlenika:";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(138, 37);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(100, 20);
            this.txtStudent.TabIndex = 20;
            // 
            // txtMeni
            // 
            this.txtMeni.Location = new System.Drawing.Point(138, 94);
            this.txtMeni.Name = "txtMeni";
            this.txtMeni.Size = new System.Drawing.Size(100, 20);
            this.txtMeni.TabIndex = 21;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(138, 153);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(100, 20);
            this.txtZaposlenik.TabIndex = 22;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(138, 208);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(134, 20);
            this.dtpDatum.TabIndex = 23;
            // 
            // Vrijeme
            // 
            this.Vrijeme.Location = new System.Drawing.Point(417, 40);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Size = new System.Drawing.Size(137, 20);
            this.Vrijeme.TabIndex = 24;
            this.Vrijeme.ValueChanged += new System.EventHandler(this.Vrijeme_ValueChanged);
            // 
            // FrmDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 386);
            this.Controls.Add(this.Vrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.txtMeni);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKupon);
            this.Controls.Add(this.txtCijena);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDodavanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje narudzbe";
            this.Load += new System.EventHandler(this.FrmDodavanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKupon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.TextBox txtMeni;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker Vrijeme;
    }
}