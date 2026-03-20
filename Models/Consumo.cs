using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static mf_apis_web_services_fuel_manager.Models.LinkDto;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Consumos")]
    public class Consumo : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime data { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]
        public TipoCombustivel Tipo{ get; set; }

        [Required]
        public int VeiculoId {  get; set; }
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Disel,
        Etanol,
        Gasolina
    }
}
