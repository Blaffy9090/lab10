using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba10.Data
{
    public class Zakaz
    {
        private decimal obshayaStoimost;

        public int ZakazId { get; set; }
        public int Kolichestvo { get; set; }
        public DateTime DataZakaza { get; set; }
        public decimal ObshayaStoimost
        {
            get
            {
                return CenaTovara * Kolichestvo;
            }
            set => obshayaStoimost = value;
        }
        public int TovarId { get; set; }
        public virtual Tovar? Tovar { get; set; }
        public decimal CenaTovara => Tovar?.Cena ?? 0;
    }
}
