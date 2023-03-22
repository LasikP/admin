using System.ComponentModel.DataAnnotations.Schema;

namespace Ski_Rental.Models
{
    public class Rezerwacja
    {
        [ForeignKey("Sprzet")]
        public int SprzetID { get; set; }

        public string TypSprzetu { get; set; }

        public DateTime DataOdbioru { get; set; }

        public DateTime DataZwrotu { get; set; }

        public virtual object Sprzet { get; set; }
    }
}

