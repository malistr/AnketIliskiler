namespace Anket.Models
{
    public class Cevap
    {
        public int CevapId { get; set; }
        public string Icerik { get; set; }

        public int SoruId { get; set; }
        public Soru Soru { get; set;}

        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
    }
}
