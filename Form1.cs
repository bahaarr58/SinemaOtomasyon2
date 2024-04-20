using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SinemaOtomasyon2.Services;

namespace SinemaOtomasyon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += FilmleriListele;
        }

        FilmServis _filmServis = new FilmServis();
        SeansServis _seansServis = new SeansServis();
        List<string> occupiedKoltuk = new List<string>();
        string secilenKoltuk;
        int secilen_seans;

        private void FilmleriListele(object sender, EventArgs e)
        {
            var filmler = _filmServis.GetAll();
            cb_filmAdi.DataSource = filmler.Select(film => film.filmAdi).ToList();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (cb_filmAdi.SelectedItem != null) 
            {
                tabControl1.SelectedTab = tabPage2;
                SeanslariListele(sender, e);
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçiniz.");
            }
           
        }

        private void SeanslariListele(object sender, EventArgs e)
        {
            string filmAdi = cb_filmAdi.SelectedItem.ToString();
            lb_filmAdi.Text = filmAdi;
            var seanslar = _seansServis.FilmleriSeansaGoreListele(filmAdi);
            dgv_seans.Rows.Clear();
            foreach (var seans in seanslar)
            {
                dgv_seans.Rows.Add(seans.id, seans.salonId, seans.tarih, seans.zaman);
            }
        }

        private void dgv_seans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumnIndex = 0;
            int ClickedRowIndex = e.RowIndex;

            DataGridViewRow selectedRow = dgv_seans.Rows[ClickedRowIndex];

            if (selectedRow.Cells[idColumnIndex].Value != null)
            {
                secilen_seans = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);
                tabControl1.SelectedTab = tabPage3;
                tabPage3_Click(null, null);
            }
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            const int KoltukGap = 5;
            const int KoltukWidth = 50;
            const int KoltukHeight = 50;
            int rowCount = 5;
            int columnCount = 10;

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
            int totalWidth = columnCount * (KoltukWidth + KoltukGap);
            int totalHeight = rowCount * (KoltukHeight + KoltukGap);
            int startX = (ClientSize.Width - totalWidth) / 2;
            int startY = (ClientSize.Height - totalHeight) / 2;
            
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btnKoltuk = new Button();
                    btnKoltuk.Cursor = Cursors.Hand;
                    btnKoltuk.Name = $"btnSeat_{letters[row]}{col + 1}";
                    btnKoltuk.Text = $"{letters[row]}{col + 1}";
                    if (occupiedKoltuk.Contains(btnKoltuk.Text))
                    {
                        btnKoltuk.BackColor = Color.LimeGreen;
                        btnKoltuk.ForeColor = Color.White;
                    }

                    btnKoltuk.Width = KoltukWidth;
                    btnKoltuk.Height = KoltukHeight;
                    btnKoltuk.Left = startX + col * (KoltukWidth + KoltukGap);
                    btnKoltuk.Top = startY + row * (KoltukHeight + KoltukGap);

                    btnKoltuk.Click += BtnKoltuk_Click;
                    tabPage3.Controls.Add(btnKoltuk);
                }
            }
        }

        private void BtnKoltuk_Click(object sender, EventArgs e)
        {
            string KoltukAdi = ((Button)sender).Name;
            string KoltukNo = KoltukAdi.Substring(KoltukAdi.IndexOf('_') + 1);

            if (occupiedKoltuk.Contains(KoltukNo))
            {
                MessageBox.Show("Koltuk zaten alındı");
                return;
            }
            secilenKoltuk = KoltukNo;

            lb_KoltukSecimi.Text = $"Koltuk Seç: {secilenKoltuk}";
        }

        private void btn_KoltukOnayla_Click(object sender, EventArgs e)
        {
            if (secilenKoltuk !=null)
            {
                tabControl1.SelectedTab = tabPage4; 
            }
            else
            {
                MessageBox.Show("Koltuk Seçmediniz!");
            }

            RezervasyonAyrıntıları(secilen_seans,secilenKoltuk);
        }

        private void KoltuklariListele(object sender, EventArgs e)
        {
            // Gerekirse koltuk listeleme işlemleri burada yapılabilir.
        }

        public void RezervasyonAyrıntıları(int selectedSeans, string selectedKoltuk)
        {
            var selectedSeansDetails = _seansServis.GetSeansDetailsBasedOnseansId(selectedSeans);
            var filmDetails = _filmServis.GetFilmDetailsBasedOnfilmId(selectedSeansDetails.filmId);

            lb_rez1.Text += selectedSeansDetails.id.ToString(CultureInfo.InvariantCulture);
            lb_rez3.Text += selectedSeansDetails.tarih;
            lb_rez3.Text += " - " + selectedSeansDetails.zaman;
            lb_rez2.Text += filmDetails.filmAdi;
            lb_rez4.Text += selectedSeansDetails.salonId.ToString();
            lb_rez5.Text += selectedKoltuk + " ";
        }

        private void lb_filmAdi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

