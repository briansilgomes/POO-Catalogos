using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    public class CatalogoInterno : Catalogo, ICatalogoInterno
    {
      
        public CatalogoInterno() {
            this.CatalogoInternoList();
        }

        public CatalogoInterno(int codigoCatalogo, string nomeCatalogo, int tipoCatalogo, DateTime dataModificacao, string caminhoFicheiro, string caminhoImagem)
        {
            this.codigoCatalogo = codigoCatalogo;
            this.nomeCatalogo = nomeCatalogo;
            this.tipoCatalogo= tipoCatalogo;
            this.dataModificacao = dataModificacao;
            this.caminhoFicheiro = caminhoFicheiro;
            this.caminhoImagem = caminhoImagem;

        }

        //List - catalogos internos
        public List<CatalogoInterno> CatalogoInternoList()
        {

            List<CatalogoInterno> internoList = new List<CatalogoInterno>()
            {
                new CatalogoInterno(142, "Máquinas", 1, DateTime.Now, "file.pdf", "image.png"),
                new CatalogoInterno(150, "Carrinhos", 1, DateTime.Now, "file.pdf", "image.png"),
            }.ToList();

            return internoList;
         
        }

        //Insert - catalogos internos
        public CatalogoInterno InserirCatalogo(CatalogoInterno catalogo)
        {
            Console.WriteLine($"Inseriu o catálogo ({catalogo.nomeCatalogo}) com sucesso!");
            return catalogo;
        }

        //Total - catalogos internos
        public override int TotalCatalogo()
        {
            return CatalogoInternoList().Count;
        }

        //Verifica se já existe - catalogos internos
        public override bool VerificarCatalogo(string nomecatalogo)
        {
            if (nomecatalogo == "Carrinhos") { return true; }
            return false;
        }

       
    }
}
