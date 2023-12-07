namespace Anket.Models
{
    public class Soru
    {
        public int SoruId { get; set; } 
        public string Icerik { get; set; }

        public int AnketId { get; set; }
        public Anket Anket { get; set; }

        public ICollection<Cevap> Cevaplar { get; set; }
    }
}
