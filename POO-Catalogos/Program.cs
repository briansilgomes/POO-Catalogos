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
           
            CatalogoInterno catalogoInterno = new CatalogoInterno();
            catalogoInterno.nomeCatalogo = "147 - Tubos";

            if (catalogoInterno.VerificarCatalogo(catalogoInterno.nomeCatalogo) == true) catalogoInterno.InserirCatalogo(catalogoInterno);
            
            Console.WriteLine(catalogoInterno.TotalCatalogo());
            Console.ReadKey();
   
        }
    }
}
