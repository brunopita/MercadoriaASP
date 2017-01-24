using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Negocio.Models.Banco
{
    public class mercadoria
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name="Preço")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        [Display(Name="Tipo de mercadoria")]
        [ForeignKey("TipoMercadoria")]
        public int TipoMercadoriaId { get; set; }
        public virtual tipoMercadoria TipoMercadoria { get; set; }
    }
}