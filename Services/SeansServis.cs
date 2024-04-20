using SinemaOtomasyon2.Data;
using SinemaOtomasyon2.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinemaOtomasyon2.Services
{
    public class SeansServis
    {
        private AppDbContext _dbContext;

        public SeansServis()
        {
            _dbContext = new AppDbContext();
        }

        // Tüm seansları getir
        public List<Seans> TumunuGetir()
        {
            return _dbContext.Seans.ToList();
        }

        // Bir film adına göre seansları listele
        public List<Seans> FilmleriSeansaGoreListele(string filmAdi)
        {
            var seanslar = _dbContext.Seans
                .Join(_dbContext.Film,
                    seans => seans.FilmId,
                    film => film.Id,
                    (seans, film) => new { Seans = seans, FilmAdi = film.FilmAdi })
                .Where(x => x.FilmAdi == filmAdi)
                .Select(x => x.Seans)
                .ToList();

            return seanslar;
        }

        // Bir seansın detaylarını seans kimliğine göre al
        public Seans SeansDetaylariniAl(int seansId)
        {
            return _dbContext.Seans.FirstOrDefault(s => s.Id == seansId);
        }
    }
}