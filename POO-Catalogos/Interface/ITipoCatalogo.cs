using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    internal interface ITipoCatalogo
    {
        string GetTipoCatalogo(int idproduto);
        List<TipoCatalogo> GetTiposCatalogoList();
    }
}
