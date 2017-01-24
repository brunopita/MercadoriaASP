using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Negocio.Models.Banco
{
    public class negocio
    {
        public int Id { get; set; }
        [Display(Name="Dt. Negociação")]
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        [Display(Name="Mercadoria")]
        [ForeignKey("Mercadoria")]
        public int MercadoriaId { get; set; }
        [Display(Name="Tipo Negociação")]
        [ForeignKey("TipoNegocio")]
        public int TipoNegocioId { get; set; }
        public virtual mercadoria Mercadoria { get; set; }
        public virtual tipoNegocio TipoNegocio { get; set; }
    }
}