using SinemaOtomasyon2.Data;
using SinemaOtomasyon2.Models;
using System.Collections.Generic;
using System.Linq;

namespace SinemaOtomasyon2.Services
{
    public class FilmServis
    {
        private AppDbContext _dbContext;

        public FilmServis()
        {
            _dbContext = new AppDbContext();
        }

        // Tüm filmleri getir
        public List<Film> TumunuGetir()
        {
            return _dbContext.Film.ToList();
        }

        // Bir film için detayları getir
        public Film FilmDetaylariniGetir(int filmId)
        {
            return _dbContext.Film.FirstOrDefault(f => f.Id == filmId);
        }

        public object GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}