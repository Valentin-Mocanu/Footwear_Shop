using System;
using System.Collections.Generic; // Pentru liste
using System.IO;
using System.Linq; // Expresii Lambda
using System.Windows.Forms;

namespace MagazinIncaltaminteGUI
{
    public partial class Form1 : Form
    {
        // ----- COLECTII -----
        // Lista de produse
        private List<ProdusStoc> produse = new List<ProdusStoc>();
        private string fisierText = "stoc.txt";

        public Form1()
        {
            InitializeComponent();
            buttonVinde.Click += ButtonVinde_Click;
            buttonAdauga.Click += ButtonAdauga_Click;
            buttonIncarcaDate.Click += ButtonIncarcaDate_Click;
            buttonSalveazaDate.Click += ButtonSalveazaDate_Click;

            // Incarcarea initiala din fisier, daca exista
            if (File.Exists(fisierText)) IncarcaStoc();
            RefreshLista();
        }

        // Afisarea produselor in listbox
        private void RefreshLista()
        {
            listBoxProduse.Items.Clear();
            foreach (var p in produse)
                listBoxProduse.Items.Add(p.Descriere());
        }

        // ----- EXPRESII LAMBDA -----
        // Produse cu stoc mic
        private List<ProdusStoc> ProduseCuStocMic()
        {
            return produse
                .Where(p => p.Cantitate < 5)
                .ToList();
        }

        // Vinde produsele din stoc
        private void ButtonVinde_Click(object sender, EventArgs e)
        {
            if (listBoxProduse.SelectedIndex < 0)
            {
                MessageBox.Show("Selectati un produs inainte de a vinde!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numCantitate.Value <= 0)
            {
                MessageBox.Show("Cantitatea trebuie sa fie mai mare decat 0!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                produse[listBoxProduse.SelectedIndex]
                    .Vinde((int)numCantitate.Value);

                RefreshLista();
            }
            catch (ExceptieStoc ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Adauga produse in stoc
        private void ButtonAdauga_Click(object sender, EventArgs e)
        {
            if (listBoxProduse.SelectedIndex < 0)
            {
                MessageBox.Show("Selectati un produs inainte de a adauga stoc!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numCantitate.Value <= 0)
            {
                MessageBox.Show("Cantitatea trebuie sa fie mai mare decat 0!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            produse[listBoxProduse.SelectedIndex]
                .Adauga((int)numCantitate.Value);

            RefreshLista();
        }

        // Salveaza produsele in fisierul text
        private void ButtonSalveazaDate_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(fisierText))
            {
                foreach (var p in produse)
                    // Scrie fiecare produs pe o linie
                    sw.WriteLine($"{p.Denumire};{p.Brand};{p.Pret};{p.Marime};{p.Cantitate}");
            }
            MessageBox.Show("Produsele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Incarca produsele din fisierul text
        private void ButtonIncarcaDate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fisierText))
            {
                MessageBox.Show("Fisierul de stoc nu exista!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool incarcat = IncarcaStoc();

            if (incarcat)
            {
                RefreshLista();

                MessageBox.Show("Produsele au fost incarcate cu succes!", "Incarcare", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var stocMic = ProduseCuStocMic();
                if (stocMic.Count > 0)
                {
                    MessageBox.Show($"Stoc redus! Exista {stocMic.Count} produse cu stoc mic!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        // Incarca si afiseaza produsele in listbox
        private bool IncarcaStoc()
        {
            produse.Clear();

            try
            {
                foreach (var linie in File.ReadAllLines(fisierText))
                {
                    if (string.IsNullOrWhiteSpace(linie))
                        continue;

                    var parts = linie.Split(';');

                    if (parts.Length != 5)
                        throw new Exception("Format invalid in fisier!");

                    string denumire = parts[0];
                    string brand = parts[1];

                    if (!double.TryParse(parts[2], out double pret))
                        throw new Exception("Pret invalid in fisier!");

                    if (!int.TryParse(parts[3], out int marime))
                        throw new Exception("Marime invalida in fisier!");

                    if (!int.TryParse(parts[4], out int cantitate))
                        throw new Exception("Cantitate invalida in fisier!");

                    if (cantitate < 0)
                        throw new Exception("Cantitatea nu poate fi negativa!");

                    produse.Add(new ProdusStoc(
                        denumire, brand, pret, marime, cantitate));
                }

                return true;
            }
            catch (Exception ex)
            {
                produse.Clear();
                MessageBox.Show("Eroare la citirea fisierului:\n\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }


        // ----- LUCRUL CU EXCEPTII -----
        // Exceptie personalizata
        public class ExceptieStoc : Exception
        {
            public ExceptieStoc(string mesaj) : base(mesaj) { }
        }

        // ----- INTERFETE -----
        // Defineste comportamentul
        public interface IStoc
        {
            void Adauga(int cantitate);
            void Vinde(int cantitate);
        }

        // ----- CLASA ABSTRACTA -----
        public abstract class Produs
        {
            public string Denumire { get; set; }
            public string Brand { get; set; }
            public double Pret { get; set; }

            protected Produs(string denumire, string brand, double pret)
            {
                Denumire = denumire;
                Brand = brand;
                Pret = pret;
            }

            // ----- POLIMORFISM -----
            public abstract string Descriere();
        }


        // ----- MOSTENIRE SIMPLA -----
        public class Incaltaminte : Produs
        {
            public int Marime { get; set; }

            public Incaltaminte(string denumire, string brand, double pret, int marime)
                : base(denumire, brand, pret)
            {
                Marime = marime;
            }

            public override string Descriere()
            {
                return $"{Denumire} | {Brand} | {Marime} | {Pret} lei";
            }
        }


        public class ProdusStoc : Incaltaminte, IStoc
        {
            public int Cantitate { get; private set; }

            public ProdusStoc(string d, string b, double p, int m, int c)
                : base(d, b, p, m)
            {
                Cantitate = c;
            }

            public override string Descriere()
            {
                return $"{Denumire} | {Brand} | {Marime} | {Pret} lei | Stoc: {Cantitate}";
            }

            public void Adauga(int cantitate)
            {
                Cantitate += cantitate;
            }

            public void Vinde(int cantitate)
            {
                if (cantitate > Cantitate)
                    throw new ExceptieStoc("Stoc insuficient!");
                Cantitate -= cantitate;
            }
        }

    }
}