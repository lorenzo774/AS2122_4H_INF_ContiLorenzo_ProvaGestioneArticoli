using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmMain : Form
    {
        private List<Articolo> articoli;

        public frmMain()
        {
            InitializeComponent();

            // TODO: (4) creazione lista articoli
            // ...
            articoli = new List<Articolo>();
        }

        private void btnAggiungiArticolo_Click(object sender, EventArgs e)
        {
            frmArticolo f = new frmArticolo();

            f.ShowDialog();

            if (f.Status == DialogResult.OK)
            {
                // aggiungi l'articolo all'elenco di articoli
                // TODO: (1) aggiungere l'articolo creato dai dati di frmArticoli nella lista articoli
                // ...
                articoli.Add(new Articolo(articoli.Count, f.Descrizione, f.UnitaMisura, f.Prezzo));

                lblArticoliInseriti.Text = $"Articoli ({articoli.Count})";
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            switch (cmbVisualizza.Text)
            {
                case "Visualizza articoli":
                    // TODO: (2) aggiungere visualizzazione articoli inseriti nella listbox
                    // ... lstElenco.Items.Add(a.Visualizzati()); 
                    lstElenco.DataSource = null;
                    lstElenco.DataSource = articoli;
                    lstElenco.DisplayMember = "Visualizzati";
                    break;
            }
        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curItem = (lstElenco.SelectedItem as Articolo);
            if (curItem == null) return;

            // TODO: (3) aggiungere visualizzazione dettaglio articolo nelle label
            // ... lblDescrizione.Text = articoli[index].Descrizione;
            //var articolo = articoli[index];

            lblDescrizione.Text = curItem.Descrizione;
            lblPrezzo.Text = curItem.Prezzo.ToString();
            lblUnitaMisura.Text = curItem.UnitaMisura;
            lblArticoliInseriti.Text = articoli.Count.ToString();
        }
    }
}
