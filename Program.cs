using System;
using System.Windows.Forms;

namespace SinemaOtomasyon2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanı başlatılması
            DbInitializer.InitializeDatabase();

            // Uygulama ana formunu başlatma
            using (var form1 = new Form1())
            {
                Application.Run(form1);
            }
        }
    }

    internal class DbInitializer
    {
        public static void InitializeDatabase()
        {
            throw new NotImplementedException();
        }
    }
}