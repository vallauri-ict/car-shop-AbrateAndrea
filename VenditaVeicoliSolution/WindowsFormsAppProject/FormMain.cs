using System;
using System.Windows.Forms;
using VenditaVeicoliDLLProject;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        public string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\storage/";

        public FormMain()
        {
            InitializeComponent();
            listBoxVeicoli.DataSource = dbUtils.bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (dbUtils.bindingListVeicoli.Count == 0)
                dbUtils.CreateList();
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            formDialogAggiungiVeicolo dialogAggiungi = new formDialogAggiungiVeicolo(dbUtils.bindingListVeicoli);
            dialogAggiungi.ShowDialog();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {      

            Utils.SerializeToXml(dbUtils.bindingListVeicoli, path +"Veicoli.xml");

            Utils.SerializeToJson(dbUtils.bindingListVeicoli, path + "Veicoli.json");
        }

        private void stampaToolStripButton_Click(object sender, EventArgs e)
        {
            string webPath = ($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\storage/www/index.html");
            Utils.createHtml(dbUtils.bindingListVeicoli, webPath); 
            System.Diagnostics.Process.Start(webPath);
        }

        private void excelToolStripButton_Click(object sender, EventArgs e)
        {
            Utils.SerializeToCsv(dbUtils.bindingListVeicoli,path+"Veicoli.csv");
        }
    }
}
