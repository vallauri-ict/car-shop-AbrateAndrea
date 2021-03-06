﻿using System;

namespace VenditaVeicoliDLLProject
{
    [Serializable()]
    public class Moto:Veicolo
    {

        private string marcaSella;

        public Moto() : base(
            "YT9876",
            "Ducati",
            "Squalo",
            "Nero",
            1000,
            75.20,
            DateTime.Now,
            false,
            false,
            0)
        {
            this.MarcaSella = "Cavallino";
        }

        public Moto(string targa, string marca, string modello, string colore,
            int cilindrata, double potenzaKw, DateTime immatricolazione,
            bool isUsato, bool isKmZero, int kmPercorsi, string marcaSella) 
            : base(
                targa,
                marca,
                modello,
                colore,
                cilindrata,
                potenzaKw,
                immatricolazione,
                isUsato,
                isKmZero,
                kmPercorsi)
        {
            this.MarcaSella = marcaSella;
        }

        public string MarcaSella { get => marcaSella; set => marcaSella = value; }

        public override string ToString()
        {
            return $"Moto: {base.ToString()} - Sella {this.MarcaSella}";
        }
    }
}
