using System.ComponentModel.DataAnnotations;

namespace Laba10.Data
{
    public class Schetchik
    {
        public int SchetchikId { get; set; }
        public string? NomerSchetchika { get; set; }
        public string? TipSchetchika { get; set; }
        public DateTime DataUstanovki { get; set; }
        public int AbonentId { get; set; }
        public virtual Abonent? Abonent { get; set; }
        public virtual ICollection<Pokazanie>? Pokazanie { get; set; }
    }
}
