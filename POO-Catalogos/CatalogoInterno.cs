using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public class CatalogoInterno : Catalogo, ICatalogoInterno
    {

        public CatalogoInterno(int codigoCatalogo, string nomeCatalogo, string tipoCatalogo, DateTime dataModificacao, string caminhoFicheiro, string caminhoImagem)
        {
            this.codigoCatalogo = codigoCatalogo;
            this.nomeCatalogo = nomeCatalogo;
            this.tipoCatalogo= tipoCatalogo;
            this.dataModificacao = dataModificacao;
            this.caminhoFicheiro = caminhoFicheiro;
            this.caminhoImagem = caminhoImagem;
        }

        public List<CatalogoInterno> CatalogoInternoList()
        {
            var catalogos = new List<CatalogoInterno>()
           {
                new CatalogoInterno(150,"Máquinas","Interno",DateTime.Now,"C:","C:"),
                new CatalogoInterno(200,"Carrinhos","Interno",DateTime.Now,"C:","C:")

           };

            catalogos.ForEach(cat => Console.WriteLine(cat.nomeCatalogo));

            return catalogos;
                    
        }

        public CatalogoInterno InserirCatalogo(CatalogoInterno catalogo)
        {
           Console.WriteLine($"Inseriu o catálogo ({catalogo.nomeCatalogo}) com sucesso!");
           return catalogo;
        }

        public override int TotalCatalogo()
        {
            int total = 0;
            return total +1 ;
        }

        public override bool VerificarCatalogo(string nomecatalogo)
        {
            if (nomecatalogo == null) { return false; }
            return true;
        }

       
    }
}
