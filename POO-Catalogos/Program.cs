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

            CatalogoInterno catalogoInterno = new CatalogoInterno(147,"Tubos","Interno",DateTime.Now,"file.txt","image.png");
         
            if (catalogoInterno.VerificarCatalogo(catalogoInterno.nomeCatalogo) == true) catalogoInterno.InserirCatalogo(catalogoInterno);
            
            Console.WriteLine($"Total: {catalogoInterno.TotalCatalogo()}");

            catalogoInterno.CatalogoInternoList();

            Console.ReadKey();
   
        }
    }
}
