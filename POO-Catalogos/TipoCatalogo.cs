using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public class TipoCatalogo: ITipoCatalogo
    {
        private int idTipoCatalogo { get; set; }
        private string tipoCatalogo { get; set; }


        public TipoCatalogo() {
            this.GetTiposCatalogoList();
        }

        public TipoCatalogo(int idproduto, string tipoProduto)
        {
            this.idTipoCatalogo = idproduto;
            this.tipoCatalogo = tipoProduto;
        }

        //Get tipo de catálogo por ID 
        public string GetTipoCatalogo(int idproduto)
        {
            var result = (from tipo in GetTiposCatalogoList()
                          where tipo.idTipoCatalogo == idproduto
                         select tipo.tipoCatalogo).FirstOrDefault();

            return result; 
        }

        //Lista tipo de catálogos
        public List<TipoCatalogo> GetTiposCatalogoList()
        {
          List<TipoCatalogo> tiposProdutoList = new List<TipoCatalogo>()
            {
                new TipoCatalogo(1,"Promoções"),
                new TipoCatalogo(2,"Máquinas e Ferramentas"),
            }.ToList();
          
            return tiposProdutoList;
        }
    }
}
