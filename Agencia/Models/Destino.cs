using System.ComponentModel.DataAnnotations;

namespace Agencia.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        public string NomeDestino { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
    }
}
