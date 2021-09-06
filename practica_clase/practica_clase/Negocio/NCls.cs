using practica_clase.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_clase.Negocio
{
    class NCls
    {
        public String clase(Entidad entidad)
        {


            while ( == 1)
            {

                Console.WriteLine("Coloca un valor a sacar tu dinero");
                int x = Convert.ToInt32(Console.ReadLine());


                if (x % 5 == 0)
                {

                    Console.WriteLine("Puedes sacar tu dinero");
                }
                else
                {

                    Console.WriteLine("Erro no puedes sacar tu dinero");
                    dat = 2;
                }
            }
        }
    }
}
