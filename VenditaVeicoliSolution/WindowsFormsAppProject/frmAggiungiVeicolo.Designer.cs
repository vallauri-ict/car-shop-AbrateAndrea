namespace WindowsFormsAppProject
{
    partial class formDialogAggiungiVeicolo
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
            this.bntnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbVeicolo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nCilindrata = new System.Windows.Forms.NumericUpDown();
            this.nPot = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUsatoNo = new System.Windows.Forms.RadioButton();
            this.rdbUsatoSi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KMZeroNo = new System.Windows.Forms.RadioButton();
            this.KMZeroSi = new System.Windows.Forms.RadioButton();
            this.nPercorsi = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVeicolo = new System.Windows.Forms.Label();
            this.txtMarcasella = new System.Windows.Forms.TextBox();
            this.nAirbag = new System.Windows.Forms.NumericUpDown();
            this.dtpImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPercorsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAirbag)).BeginInit();
            this.SuspendLayout();
            // 
            // bntnAnnulla
            // 
            this.bntnAnnulla.Location = new System.Drawing.Point(170, 385);
            this.bntnAnnulla.Name = "bntnAnnulla";
            this.bntnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.bntnAnnulla.TabIndex = 0;
            this.bntnAnnulla.Text = "ANNULLA";
            this.bntnAnnulla.UseVisualStyleBackColor = true;
            this.bntnAnnulla.Click += new System.EventHandler(this.bntnAnnulla_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(251, 385);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbVeicolo
            // 
            this.cmbVeicolo.FormattingEnabled = true;
            this.cmbVeicolo.Items.AddRange(new object[] {
            "AUTO",
            "MOTO"});
            this.cmbVeicolo.Location = new System.Drawing.Point(124, 21);
            this.cmbVeicolo.Name = "cmbVeicolo";
            this.cmbVeicolo.Size = new System.Drawing.Size(121, 21);
            this.cmbVeicolo.TabIndex = 2;
            this.cmbVeicolo.SelectedIndexChanged += new System.EventHandler(this.cmbVeicolo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(124, 104);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(124, 130);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 20);
            this.txtModello.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modello";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(124, 156);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 20);
            this.txtColore.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cilindrata";
            // 
            // nCilindrata
            // 
            this.nCilindrata.Location = new System.Drawing.Point(124, 183);
            this.nCilindrata.Name = "nCilindrata";
            this.nCilindrata.Size = new System.Drawing.Size(100, 20);
            this.nCilindrata.TabIndex = 10;
            // 
            // nPot
            // 
            this.nPot.DecimalPlaces = 2;
            this.nPot.Location = new System.Drawing.Point(124, 209);
            this.nPot.Name = "nPot";
            this.nPot.Size = new System.Drawing.Size(100, 20);
            this.nPot.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Potenza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Immatricolazione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "KM Zero?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUsatoNo);
            this.groupBox1.Controls.Add(this.rdbUsatoSi);
            this.groupBox1.Location = new System.Drawing.Point(124, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 21);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // rdbUsatoNo
            // 
            this.rdbUsatoNo.AutoSize = true;
            this.rdbUsatoNo.Checked = true;
            this.rdbUsatoNo.Location = new System.Drawing.Point(47, 0);
            this.rdbUsatoNo.Name = "rdbUsatoNo";
            this.rdbUsatoNo.Size = new System.Drawing.Size(41, 17);
            this.rdbUsatoNo.TabIndex = 1;
            this.rdbUsatoNo.TabStop = true;
            this.rdbUsatoNo.Text = "NO";
            this.rdbUsatoNo.UseVisualStyleBackColor = true;
            // 
            // rdbUsatoSi
            // 
            this.rdbUsatoSi.AutoSize = true;
            this.rdbUsatoSi.Location = new System.Drawing.Point(6, 0);
            this.rdbUsatoSi.Name = "rdbUsatoSi";
            this.rdbUsatoSi.Size = new System.Drawing.Size(35, 17);
            this.rdbUsatoSi.TabIndex = 0;
            this.rdbUsatoSi.Text = "SI";
            this.rdbUsatoSi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KMZeroNo);
            this.groupBox2.Controls.Add(this.KMZeroSi);
            this.groupBox2.Location = new System.Drawing.Point(124, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 21);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // KMZeroNo
            // 
            this.KMZeroNo.AutoSize = true;
            this.KMZeroNo.Checked = true;
            this.KMZeroNo.Location = new System.Drawing.Point(47, 0);
            this.KMZeroNo.Name = "KMZeroNo";
            this.KMZeroNo.Size = new System.Drawing.Size(41, 17);
            this.KMZeroNo.TabIndex = 1;
            this.KMZeroNo.TabStop = true;
            this.KMZeroNo.Text = "NO";
            this.KMZeroNo.UseVisualStyleBackColor = true;
            // 
            // KMZeroSi
            // 
            this.KMZeroSi.AutoSize = true;
            this.KMZeroSi.Location = new System.Drawing.Point(6, 0);
            this.KMZeroSi.Name = "KMZeroSi";
            this.KMZeroSi.Size = new System.Drawing.Size(35, 17);
            this.KMZeroSi.TabIndex = 0;
            this.KMZeroSi.Text = "SI";
            this.KMZeroSi.UseVisualStyleBackColor = true;
            // 
            // nPercorsi
            // 
            this.nPercorsi.Location = new System.Drawing.Point(124, 317);
            this.nPercorsi.Name = "nPercorsi";
            this.nPercorsi.Size = new System.Drawing.Size(100, 20);
            this.nPercorsi.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "KM percorsi";
            // 
            // lblVeicolo
            // 
            this.lblVeicolo.AutoSize = true;
            this.lblVeicolo.Location = new System.Drawing.Point(33, 351);
            this.lblVeicolo.Name = "lblVeicolo";
            this.lblVeicolo.Size = new System.Drawing.Size(77, 13);
            this.lblVeicolo.TabIndex = 23;
            this.lblVeicolo.Text = "Numero Airbag";
            // 
            // txtMarcasella
            // 
            this.txtMarcasella.Location = new System.Drawing.Point(124, 349);
            this.txtMarcasella.Name = "txtMarcasella";
            this.txtMarcasella.Size = new System.Drawing.Size(100, 20);
            this.txtMarcasella.TabIndex = 24;
            this.txtMarcasella.Visible = false;
            // 
            // nAirbag
            // 
            this.nAirbag.Location = new System.Drawing.Point(124, 349);
            this.nAirbag.Name = "nAirbag";
            this.nAirbag.Size = new System.Drawing.Size(120, 20);
            this.nAirbag.TabIndex = 25;
            // 
            // dtpImmatricolazione
            // 
            this.dtpImmatricolazione.Location = new System.Drawing.Point(124, 237);
            this.dtpImmatricolazione.Name = "dtpImmatricolazione";
            this.dtpImmatricolazione.Size = new System.Drawing.Size(167, 20);
            this.dtpImmatricolazione.TabIndex = 26;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(124, 78);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Targa";
            // 
            // formDialogAggiungiVeicolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 420);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpImmatricolazione);
            this.Controls.Add(this.nAirbag);
            this.Controls.Add(this.txtMarcasella);
            this.Controls.Add(this.lblVeicolo);
            this.Controls.Add(this.nPercorsi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nPot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nCilindrata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVeicolo);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.bntnAnnulla);
            this.Name = "formDialogAggiungiVeicolo";
            this.Text = "formDialogAggiungiVeicolo";
            this.Load += new System.EventHandler(this.formDialogAggiungiVeicolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nCilindrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPercorsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAirbag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntnAnnulla;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbVeicolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nCilindrata;
        private System.Windows.Forms.NumericUpDown nPot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUsatoNo;
        private System.Windows.Forms.RadioButton rdbUsatoSi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton KMZeroNo;
        private System.Windows.Forms.RadioButton KMZeroSi;
        private System.Windows.Forms.NumericUpDown nPercorsi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVeicolo;
        private System.Windows.Forms.TextBox txtMarcasella;
        private System.Windows.Forms.NumericUpDown nAirbag;
        private System.Windows.Forms.DateTimePicker dtpImmatricolazione;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.Label label10;
    }
}