using System.ComponentModel.DataAnnotations;

namespace Laba10.Data
{
    public class KategoriyaTovara
    {
        public int KategoriyaTovaraId { get; set; } 
        public string NazvanieKategorii { get; set; }
        public virtual ICollection<Tovar>? Tovary { get; set; }
    }
}
