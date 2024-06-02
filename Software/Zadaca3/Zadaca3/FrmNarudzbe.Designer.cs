namespace Zadaca3
{
    partial class FrmNarudzbe
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPromjena = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(26, 137);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.Size = new System.Drawing.Size(839, 308);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDodaj.Location = new System.Drawing.Point(26, 472);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(125, 45);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj narudzbu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPromjena
            // 
            this.btnPromjena.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPromjena.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPromjena.Location = new System.Drawing.Point(745, 472);
            this.btnPromjena.Name = "btnPromjena";
            this.btnPromjena.Size = new System.Drawing.Size(120, 44);
            this.btnPromjena.TabIndex = 2;
            this.btnPromjena.Text = "Promjena statusa";
            this.btnPromjena.UseVisualStyleBackColor = false;
            this.btnPromjena.Click += new System.EventHandler(this.btnPromjena_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Info;
            this.btnIzbrisi.Location = new System.Drawing.Point(171, 472);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(122, 45);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Obrisi narudzbu";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(146, 17);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretrazivanje po statusu:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPretrazi.Location = new System.Drawing.Point(332, 65);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(123, 44);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretrazi narudzbe";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 56);
            this.panel1.TabIndex = 7;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logo.Location = new System.Drawing.Point(21, 19);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(89, 25);
            this.logo.TabIndex = 8;
            this.logo.Text = "MyMenu";
            // 
            // FrmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 538);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPromjena);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvNarudzbe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled narudzbi";
            this.Load += new System.EventHandler(this.FrmNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPromjena;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logo;
    }
}