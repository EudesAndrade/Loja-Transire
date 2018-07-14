
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Web.Models
{
    
    public partial class Produto
    {
        public int ID { get; set; }

        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}