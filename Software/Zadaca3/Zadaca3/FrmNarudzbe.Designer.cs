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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.Size = new System.Drawing.Size(578, 308);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(644, 70);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj narudzbu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPromjena
            // 
            this.btnPromjena.Location = new System.Drawing.Point(645, 138);
            this.btnPromjena.Name = "btnPromjena";
            this.btnPromjena.Size = new System.Drawing.Size(103, 23);
            this.btnPromjena.TabIndex = 2;
            this.btnPromjena.Text = "Promjena statusa";
            this.btnPromjena.UseVisualStyleBackColor = true;
            this.btnPromjena.Click += new System.EventHandler(this.btnPromjena_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(644, 203);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(104, 23);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Obrisi narudzbu";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // FrmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPromjena;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}