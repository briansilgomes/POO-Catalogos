using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public abstract class Catalogo
    {
        public int codigoCatalogo { get; set; }
        public string nomeCatalogo { get; set; }
        public int tipoCatalogo { get; set; }
        public DateTime dataModificacao { get; set; }
        public string caminhoFicheiro { get; set; }
        public string caminhoImagem { get; set; }
       
        public abstract int TotalCatalogo();
        public abstract Boolean VerificarCatalogo(string nomecatalogo);

    }
}
