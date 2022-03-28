
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
            this.cmbUnitaMisura.AutoCompleteCustomSource.AddRange(new string[] {
            "KG",
            "T"});
            this.cmbUnitaMisura.FormattingEnabled = true;
            this.cmbUnitaMisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmbUnitaMisura.Location = new System.Drawing.Point(166, 58);
            this.cmbUnitaMisura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnitaMisura.Name = "cmbUnitaMisura";
            this.cmbUnitaMisura.Size = new System.Drawing.Size(60, 23);
            this.cmbUnitaMisura.TabIndex = 2;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(166, 90);
            this.txtPrezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(129, 23);
            this.txtPrezzo.TabIndex = 3;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(166, 27);
            this.txtDescrizione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(224, 23);
            this.txtDescrizione.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unità di misura";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(95, 134);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(110, 34);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(299, 134);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(110, 34);
            this.btnAnnulla.TabIndex = 13;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // frmArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 188);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.cmbUnitaMisura);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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