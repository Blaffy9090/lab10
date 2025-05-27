using System.ComponentModel.DataAnnotations;

namespace Laba10.Data
{
    public class Pokazanie
    {
        public int PokazanieId { get; set; }
        public DateTime DataPokazaniya { get; set; }
        public float ZnacheniePokazaniya { get; set; }
        public int SchetchikId { get; set; }
        public virtual Schetchik? Schetchik { get; set; }
    }
}
