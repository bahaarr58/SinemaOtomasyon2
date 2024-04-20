using System.Data.SQLite;
using System.IO;

namespace SinemaOtomasyon2.Data
{
    public static class VeritabaniBaslatici
    {
        private static string baglantiCumlesi = "Data Source=..\\..\\dosyalar\\SinemaOtomasyon2Db.db;Version=3;";

        public static void VeritabaniniBaslat()
        {
            if (!File.Exists("..\\..\\dosyalar\\SinemaOtomasyon2Db.db")) 
            {
                SQLiteConnection.CreateFile("..\\..\\dosyalar\\SinemaOtomasyon2Db.db");
                using (var baglanti = new SQLiteConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                  
                    string filmTablosuOlusturmaSorgusu = @"
                        CREATE TABLE IF NOT EXISTS Film(
                            id INTEGER PRIMARY KEY NOT NULL,
                            filmAdi TEXT NOT NULL
                      );";
                    string filmEklemeSorgusu = @"
                        INSERT INTO Film (filmAdi) VALUES 
                            ('DeadPool'),
                            ('Kar Kardeşliği'),
                            ('Müzede Bir Gece'),
                            ('Bay ve Bayan Smith'),
                            ('Oyuncak Hikayesi 4');";

                    string salonTablosuOlusturmaSorgusu = @"
                        CREATE TABLE IF NOT EXISTS Salon(
                            id INTEGER PRIMARY KEY NOT NULL,
                            salonAdi TEXT NOT NULL,
                            salonKapasite INTEGER NOT NULL
                        );";
                    string salonEklemeSorgusu = @"
                        INSERT INTO Salon (salonAdi, salonKapasite) VALUES 
                            ('Salon 1', 50),
                            ('Salon 2', 115),
                            ('Salon 3', 75),
                            ('Salon 4', 130),
                            ('Salon 5', 50);
                    ";
                   
                    string seansTablosuOlusturmaSorgusu = @"
                        CREATE TABLE IF NOT EXISTS Seans(
                            id INTEGER PRIMARY KEY NOT NULL,
                            tarih TEXT NOT NULL,
                            zaman TEXT NOT NULL,
                            filmId INTEGER NOT NULL,
                            salonId INTEGER NOT NULL,
                            FOREIGN KEY (filmId) REFERENCES Film(id),
                            FOREIGN KEY (salonId) REFERENCES Salon(id)
                        );";
                    string seansEklemeSorgusu = @"
                        INSERT INTO Seans (tarih, zaman, filmId, salonId ) VALUES 
                            ('13.04.2024', '16:45', 2, 3),
                            ('14.04.2024', '19:00', 1, 7),
                            ('14.04.2024', '20:00', 3, 4),
                            ('15.04.2024', '23:00', 4, 5),
                            ('16.04.2024', '00:00', 5, 6);
                    ";


                    string rezervasyonTablosuOlusturmaSorgusu = @"
                        CREATE TABLE IF NOT EXISTS Rezervasyon(
                            id INTEGER PRIMARY KEY NOT NULL,
                            koltukNo TEXT NOT NULL,
                            seansId INTEGER NOT NULL,
                            FOREIGN KEY (seansId) REFERENCES Seans(id)
                        );";
                    string rezervasyonEklemeSorgusu = @"
                   ;";


                    using (var komut = new SQLiteCommand(baglanti))
                    {
                        komut.CommandText = filmTablosuOlusturmaSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = filmEklemeSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = salonTablosuOlusturmaSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = salonEklemeSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = seansTablosuOlusturmaSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = seansEklemeSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = rezervasyonTablosuOlusturmaSorgusu;
                        komut.ExecuteNonQuery();

                        komut.CommandText = rezervasyonEklemeSorgusu;
                        komut.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}