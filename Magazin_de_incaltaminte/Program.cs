using System;
using System.Windows.Forms;
using Magazin_de_incaltaminte;


namespace MagazinIncaltaminteGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}