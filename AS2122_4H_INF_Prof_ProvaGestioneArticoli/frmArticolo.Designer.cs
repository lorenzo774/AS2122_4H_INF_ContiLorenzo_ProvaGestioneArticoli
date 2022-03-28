
namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    partial class frmArticolo
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
            this.cmbUnitaMisura = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUnitaMisura
            // 
            this.cmbUnitaMisura.FormattingEnabled = true;
            this.cmbUnitaMisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmbUnitaMisura.Location = new System.Drawing.Point(190, 78);
            this.cmbUnitaMisura.Name = "cmbUnitaMisura";
            this.cmbUnitaMisura.Size = new System.Drawing.Size(68, 28);
            this.cmbUnitaMisura.TabIndex = 2;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(190, 120);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(147, 27);
            this.txtPrezzo.TabIndex = 3;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(190, 36);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(256, 27);
            this.txtDescrizione.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unità di misura";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(109, 178);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(126, 46);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(342, 178);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(126, 46);
            this.btnAnnulla.TabIndex = 13;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // frmArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 251);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.cmbUnitaMisura);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmArticolo";
            this.Text = "Dettagli articolo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnitaMisura;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAnnulla;
    }
}