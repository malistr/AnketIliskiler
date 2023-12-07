namespace Anket.Models
{
    public class Yorum
    {
        public int YorumId { get; set; }
        public string Icerik { get; set; }

        public int AnketId { get; set; }
        public Anket Anket { get; set; }

        public int CalisanId { get; set; }
        public Calisan Calisan { get; set; }
    }
}
