namespace Anket.Models
{
    public class Calisan
    {
        public int CalisanId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public ICollection<Cevap> Cevaplar { get; set; }
        public ICollection<Yorum> Yorumlar { get; set; }
    }
}
