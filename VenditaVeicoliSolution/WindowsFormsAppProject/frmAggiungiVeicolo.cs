using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VenditaVeicoliDLLProject;

namespace WindowsFormsAppProject
{
    public partial class formDialogAggiungiVeicolo : Form
    {
        BindingList<Veicolo> BindingListVeicoli;
        public formDialogAggiungiVeicolo(BindingList<Veicolo> bindingListVeicoli)
        {
            BindingListVeicoli = bindingListVeicoli;
            InitializeComponent();
        }

        private void formDialogAggiungiVeicolo_Load(object sender, EventArgs e)
        {
            this.cmbVeicolo.SelectedIndex = 0;
        }

        private void bntnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (txtTarga.Text == "" || txtMarca.Text == "" || txtModello.Text == "" || txtColore.Text == "" || nCilindrata.Value == 0 || nPot.Value == 0  || (txtMarcasella.Text == " " && nAirbag.Value == 0))
            {
                MessageBox.Show("Errore durante l'inserimento dei dati riprovare");
                return;
            }
                bool usato = rdbUsatoSi.Checked;
                bool km0 = KMZeroSi.Checked;
                if (cmbVeicolo.Text == "MOTO")
                {
                    Moto m = new Moto(txtTarga.Text, txtMarca.Text, txtModello.Text, txtColore.Text, Convert.ToInt32(nCilindrata.Value), Convert.ToDouble(nPot.Value), dtpImmatricolazione.Value, usato, km0, Convert.ToInt32(nPercorsi.Value), txtMarcasella.Text);
                    BindingListVeicoli.Add(m);
                    string str = txtTarga.Text + "|" + txtMarca.Text + "|" + txtModello.Text + "|" + txtColore.Text + "|" + nCilindrata.Value + "|" + nPot.Value + "|" + dtpImmatricolazione.Value + "|" + usato + "|" + km0 + "|" + nPercorsi.Value + "|" + txtMarcasella.Text;
                    dbUtils.Add(str);
                    this.Close();
                }
                else if (cmbVeicolo.Text == "AUTO")
                {
                    Auto a = new Auto(txtTarga.Text, txtMarca.Text, txtModello.Text, txtColore.Text, Convert.ToInt32(nCilindrata.Value), Convert.ToDouble(nPot.Value), dtpImmatricolazione.Value, usato, km0, Convert.ToInt32(nPercorsi.Value), Convert.ToInt32(nAirbag.Value));
                    BindingListVeicoli.Add(a);
                    string str = txtTarga.Text + "|" + txtMarca.Text + "|" + txtModello.Text + "|" + txtColore.Text + "|" + nCilindrata.Value + "|" + nPot.Value + "|" + dtpImmatricolazione.Value + "|" + usato + "|" + km0 + "|" + nPercorsi.Value + "|" + nAirbag.Value;
                    dbUtils.Add(str);
                    this.Close();
                }
        }


        private void cmbVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVeicolo.SelectedItem.ToString() == "MOTO")
            {
                lblVeicolo.Text = "Marca sella";
                txtMarcasella.Visible = true;
                nAirbag.Visible = false;
            }
            else
            {
                lblVeicolo.Text = "Numero Airbag";
                txtMarcasella.Visible = false;
                nAirbag.Visible = true;
            }
        }
    }
}
