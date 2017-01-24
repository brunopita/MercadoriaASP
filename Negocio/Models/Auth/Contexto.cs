using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Negocio.Models.Auth
{
        public class Contexto : DbContext
        {
            //inicializa o banco de dados com entity, de acordo com a configuração de conexão da connectstring
            public Contexto()
                : base("Mercadoria")
            {
            }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //configura a inicialização do banco
                base.OnModelCreating(modelBuilder);
                Database.SetInitializer<Contexto>(null);

            }
        }
    
}