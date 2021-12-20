using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public string NomeDestino { get; set; }
        public int DiasReserva { get; set; }
        public DateTime DataReserva { get; set; }
    }
}
