namespace Anket.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public ICollection<Cevap> Cevaplar { get; set; }
    }
}
