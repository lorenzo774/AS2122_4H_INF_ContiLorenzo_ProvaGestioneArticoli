
namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnAggiungiArticolo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblUnitaMisura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArticoliInseriti = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 20;
            this.lstElenco.Location = new System.Drawing.Point(469, 94);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(259, 344);
            this.lstElenco.TabIndex = 0;
            this.lstElenco.SelectedIndexChanged += new System.EventHandler(this.lstElenco_SelectedIndexChanged);
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Items.AddRange(new object[] {
            "Visualizza articoli"});
            this.cmbVisualizza.Location = new System.Drawing.Point(469, 50);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(210, 28);
            this.cmbVisualizza.TabIndex = 1;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(686, 50);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(42, 29);
            this.btnVisualizza.TabIndex = 2;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnAggiungiArticolo
            // 
            this.btnAggiungiArticolo.Location = new System.Drawing.Point(233, 371);
            this.btnAggiungiArticolo.Name = "btnAggiungiArticolo";
            this.btnAggiungiArticolo.Size = new System.Drawing.Size(152, 46);
            this.btnAggiungiArticolo.TabIndex = 3;
            this.btnAggiungiArticolo.Text = "Aggiungi articolo";
            this.btnAggiungiArticolo.UseVisualStyleBackColor = true;
            this.btnAggiungiArticolo.Click += new System.EventHandler(this.btnAggiungiArticolo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrezzo);
            this.groupBox1.Controls.Add(this.lblUnitaMisura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli articolo selezionato";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(152, 125);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(18, 20);
            this.lblPrezzo.TabIndex = 10;
            this.lblPrezzo.Text = "...";
            // 
            // lblUnitaMisura
            // 
            this.lblUnitaMisura.AutoSize = true;
            this.lblUnitaMisura.Location = new System.Drawing.Point(152, 86);
            this.lblUnitaMisura.Name = "lblUnitaMisura";
            this.lblUnitaMisura.Size = new System.Drawing.Size(18, 20);
            this.lblUnitaMisura.TabIndex = 10;
            this.lblUnitaMisura.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "...";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(152, 47);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(18, 20);
            this.lblDescrizione.TabIndex = 10;
            this.lblDescrizione.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prezzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Unità di misura";
            // 
            // lblArticoliInseriti
            // 
            this.lblArticoliInseriti.AutoSize = true;
            this.lblArticoliInseriti.Location = new System.Drawing.Point(23, 384);
            this.lblArticoliInseriti.Name = "lblArticoliInseriti";
            this.lblArticoliInseriti.Size = new System.Drawing.Size(79, 20);
            this.lblArticoliInseriti.TabIndex = 10;
            this.lblArticoliInseriti.Text = "Articoli (0)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.lblArticoliInseriti);
            this.Controls.Add(this.btnAggiungiArticolo);
            this.Name = "frmMain";
            this.Text = "Prof;Lab 2.2 4H;28/03/22 Prova singola gestione articoli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstElenco;
        private System.Windows.Forms.ComboBox cmbVisualizza;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnAggiungiArticolo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblUnitaMisura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArticoliInseriti;
    }
}

