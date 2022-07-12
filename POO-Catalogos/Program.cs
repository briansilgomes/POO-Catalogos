using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Catalogos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CatalogoInterno catalogoInterno = new CatalogoInterno() 
            { codigoCatalogo = 169,
              nomeCatalogo= "Papel Indústrial",
              tipoCatalogo= 2,
              dataModificacao=DateTime.Now,
              caminhoFicheiro= "file.pdf",
              caminhoImagem="image.png"};
          
            //Verifica tipo de catalogo é válido

            TipoCatalogo tipoCatalog = new TipoCatalogo();
            string tipoCatalogo = tipoCatalog.GetTipoCatalogo(catalogoInterno.tipoCatalogo);
            if (tipoCatalogo == null) Console.WriteLine("Tipo de Catalogo não existe!");

            //Verifica nome do catálogo já existe

            if (catalogoInterno.VerificarCatalogo(catalogoInterno.nomeCatalogo) != true && tipoCatalogo != null){ 
                catalogoInterno.InserirCatalogo(catalogoInterno);
                Console.WriteLine($"Tipo de Catálogo inserido: {tipoCatalogo}");
            }else { Console.WriteLine("O Catálogo inserido já existe"); }


            //LISTAR CATALOGOS INTERNOS

            catalogoInterno.CatalogoInternoList().ForEach(c=> Console.WriteLine(c.nomeCatalogo));
            Console.WriteLine($"Total: {catalogoInterno.TotalCatalogo()}");

            Console.ReadKey();
   
        }
    }
}
