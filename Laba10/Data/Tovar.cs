using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba10.Data
{
    public class Tovar
    {
        public int TovarId { get; set; } 
        public string? NazvanieTovara { get; set; }
        public string? OpisanieTovara { get; set; }
        public decimal Cena { get; set; }
        public int KategoriyaTovaraId { get; set; }
        public virtual KategoriyaTovara? KategoriyaTovara { get; set; }
        public virtual ICollection<Zakaz>? Zakazy { get; set; }
    }
}