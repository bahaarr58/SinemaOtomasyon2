namespace SinemaOtomasyon2.Models
{
    public class Seans
    {
        public object id;
        public object salonId;
        public string tarih;
        public object zaman;

        public int Id { get; set; }

        
        public string Tarih { get; set; }

       
        public string Zaman { get; set; }

        
        public int FilmId { get; set; }

       
        public int SalonId { get; set; }
    }
}