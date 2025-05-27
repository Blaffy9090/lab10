using System.ComponentModel.DataAnnotations;

namespace Laba10.Data
{
    public class Abonent
    {
        public int AbonentId { get; set; }
        public string? Familiya { get; set; }

        public string? Imya { get; set; }

        public string? Otchestvo { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public virtual ICollection<Schetchik>? Schetchiks { get; set; }
    }
}
