using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public class CatalogoFornecedor:Catalogo
    {
        
        public string siteFornecedor { get; set; }

        public CatalogoFornecedor() { }

        public override int TotalCatalogo()
        {
            throw new NotImplementedException();
        }

        public override bool VerificarCatalogo(string nomecatalogo)
        {
            throw new NotImplementedException();
        }
    }
}
