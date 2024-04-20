using SinemaOtomasyon2.Data;
using SinemaOtomasyon2.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinemaOtomasyon2.Services
{
    public class RezervasyonServis
    {
        private AppDbContext _dbContext;

        public RezervasyonServis()
        {
            _dbContext = new AppDbContext();
        }

        // Tüm rezervasyonları getir
        public List<Rezervasyon> TumunuGetir()
        {
            return _dbContext.Rezervasyon.ToList();
        }

        // Bir seans için yapılan rezervasyonları getir
        public List<Rezervasyon> SeansRezervasyonlariniGetir(int seansId)
        {
            return _dbContext.Rezervasyon.Where(r => r.SeansId == seansId).ToList();
        }

        // Yeni bir rezervasyon oluştur
        public void RezervasyonOlustur(Rezervasyon rezervasyon)
        {
            _dbContext.Rezervasyon.Add(rezervasyon);
            _dbContext.SaveChanges();
        }

        // Bir rezervasyonu sil
        public void RezervasyonSil(int rezervasyonId)
        {
            var rezervasyon = _dbContext.Rezervasyon.Find(rezervasyonId);
            if (rezervasyon != null)
            {
                _dbContext.Rezervasyon.Remove(rezervasyon);
                _dbContext.SaveChanges();
            }
        }
    }
}