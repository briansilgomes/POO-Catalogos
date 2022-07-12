using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    internal interface ITipoProduto
    {
        string GetTipoProduto(int idproduto);
        List<TipoCatalogo> GetTiposProdutoList();
    }
}
