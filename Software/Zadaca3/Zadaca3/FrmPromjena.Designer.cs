﻿namespace Zadaca3
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
            this.numStudent = new System.Windows.Forms.NumericUpDown();
            this.numMeni = new System.Windows.Forms.NumericUpDown();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPromjena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeni)).BeginInit();
            this.SuspendLayout();
            // 
            // numStudent
            // 
            this.numStudent.Location = new System.Drawing.Point(116, 29);
            this.numStudent.Name = "numStudent";
            this.numStudent.Size = new System.Drawing.Size(120, 20);
            this.numStudent.TabIndex = 0;
            // 
            // numMeni
            // 
            this.numMeni.Location = new System.Drawing.Point(115, 81);
            this.numMeni.Name = "numMeni";
            this.numMeni.Size = new System.Drawing.Size(120, 20);
            this.numMeni.TabIndex = 1;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(115, 132);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status: ";
            // 
            // btnPromjena
            // 
            this.btnPromjena.Location = new System.Drawing.Point(96, 191);
            this.btnPromjena.Name = "btnPromjena";
            this.btnPromjena.Size = new System.Drawing.Size(75, 23);
            this.btnPromjena.TabIndex = 6;
            this.btnPromjena.Text = "Promijeni";
            this.btnPromjena.UseVisualStyleBackColor = true;
            // 
            // FrmPromjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 243);
            this.Controls.Add(this.btnPromjena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.numMeni);
            this.Controls.Add(this.numStudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPromjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena statusa";
            ((System.ComponentModel.ISupportInitialize)(this.numStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStudent;
        private System.Windows.Forms.NumericUpDown numMeni;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPromjena;
    }
}