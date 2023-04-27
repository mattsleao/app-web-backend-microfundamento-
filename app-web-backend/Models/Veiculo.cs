using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar a marca!")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o modelo!")]

        public string Modelo { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a placa!")]

        public string Placa { get; set; }
    }
}
