using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio.Models.Auth;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web.Mvc;

namespace Negocio.Models.Banco
{
    public class Db:Contexto
    {
        #region DataSet
        public DbSet<mercadoria> mercadoria { get; set; }
        public DbSet<negocio> negocio { get; set; }
        public DbSet<tipoNegocio> tipoNegocio { get; set; }
        public DbSet<tipoMercadoria> tipoMercadoria { get; set; }
        #endregion
        //inicializa a classe fazendo a conexão com a base de dados que é derivada da contexto
        #region Utilidades
        public SelectList GetTipoMercadoria()
        {
            return new SelectList(this.tipoMercadoria, "Id", "Nome");
        }
        public SelectList GetTipoNegociacao()
        {
            return new SelectList(this.tipoNegocio, "Id", "Nome");
        }
        public SelectList GetMercadoria()
        {
            return new SelectList(this.mercadoria, "Id", "Nome");
        }
        #endregion
        public Db()
            : base()
        {
        }
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //tira a pluralização padrão do entity
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //retira a conversão do entity de uma variável para outra
            modelBuilder.Conventions.Remove<RequiredPrimitivePropertyAttributeConvention>();
            //remove o cascate de delete
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}