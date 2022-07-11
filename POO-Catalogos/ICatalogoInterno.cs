using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public interface ICatalogoInterno
    {
        CatalogoInterno InserirCatalogo(CatalogoInterno catalogo);
        List<CatalogoInterno> CatalogoInternoList();
    }
}
