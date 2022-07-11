using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public class CatalogoInterno : Catalogo, ICatalogoInterno
    {

        int total = 0; 
        public void InserirCatalogo(CatalogoInterno catalogo)
        {
            Console.WriteLine($"Inseriu o catálogo ({catalogo.nomeCatalogo}) com sucesso!");
        }


        public override int TotalCatalogo()
        {
            return this.total +1 ;
        }

        public override bool VerificarCatalogo(string nomecatalogo)
        {
            if (nomecatalogo == null) { return false; }
            return true;
        }
    }
}
