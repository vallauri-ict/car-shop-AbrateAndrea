using System;
using Microsoft.VisualBasic;
using VenditaVeicoliDLLProject;

namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            char scelta;
            do
            {
                menu();
                Console.Write("DIGITA LA TUA SCELTA ");
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case '1':
                        dbUtils.CreateTableCars();
                        dbUtils.CreateList();
                        break;
                    case '2':
                        string targa = Interaction.InputBox("Inserisci la targa del veicolo"),
                               marca = Interaction.InputBox("Inserisci la marca del veicolo"),
                               modello = Interaction.InputBox("Inserisci il modello del veicolo"),
                               colore = Interaction.InputBox("Inserisci il colore del veicolo"),
                               cilindrata = Interaction.InputBox("Inserisci la cilindrata del veicolo"),
                               potenzaKw = Interaction.InputBox("Inserisci la potenza(Kw) del veicolo"),
                               dataImmatricolazione = DateTime.Now.Date.ToShortDateString(),
                               isUsato = "",
                               isKm0 = "",
                               kmPercorsi = Interaction.InputBox("Inserisci i km percorsi dal veicolo"),
                               str = Interaction.InputBox("Inserisci il numero di airbag o la marca della sella del veicolo");
                        if (Convert.ToInt32(kmPercorsi) > 0)
                        {
                            isUsato = "True";
                            isKm0 = "false";
                        }
                        else
                        {
                            isUsato = "False";
                            isKm0 = "True";
                        }
                        string parameters = targa + "|" + marca + "|" + modello + "|" + colore + "|" + cilindrata + "|" + potenzaKw + "|" + dataImmatricolazione + "|" + isUsato + "|" + isKm0 + "|" + kmPercorsi + "|" + str;

                        dbUtils.Add(parameters);
                        Console.WriteLine("\n Item added to Auto!!");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case '3':
                        dbUtils.bindingListVeicoli.Clear();
                        dbUtils.CreateList();
                        dbUtils.show();
                        break;
                    case '4':
                        targa = Interaction.InputBox("Inserisci la targa dell'elemento da eliminare");

                        dbUtils.delete(targa);
                    break;
                    default:
                        break;
                }
                
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("*** Data Menagement ***\n");
            Console.WriteLine("1 - CREATE TABLE: Cars");
            Console.WriteLine("2 - ADD NEW ITEM: Cars");
            Console.WriteLine("3 - LIST: Cars");
            Console.WriteLine("4 - DELETE: Cars");
            Console.WriteLine("\nX - FINE LAVORO\n\n");
        }
    }
}
