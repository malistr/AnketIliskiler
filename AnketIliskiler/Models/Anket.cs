namespace Anket.Models
{
    public class Anket
    {
        public int AnketId { get; set; }
        public string Baslik { get; set; }

        public ICollection<Soru> Sorular { get; set; }
    }
}
