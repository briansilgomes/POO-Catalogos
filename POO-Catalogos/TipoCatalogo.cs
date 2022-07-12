using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public class TipoCatalogo: ITipoProduto
    {
        private int idproduto { get; set; }
        private string tipoProduto { get; set; }


        public TipoCatalogo() {
            this.GetTiposProdutoList();
        }

        public TipoCatalogo(int idproduto, string tipoProduto)
        {
            this.idproduto = idproduto;
            this.tipoProduto = tipoProduto;
        }

        public string GetTipoProduto(int idproduto)
        {
            var result = (from tipo in GetTiposProdutoList()
                          where tipo.idproduto == idproduto
                         select tipo.tipoProduto).FirstOrDefault();

            return result; 
        }

        public List<TipoCatalogo> GetTiposProdutoList()
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
