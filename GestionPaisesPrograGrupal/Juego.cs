using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class Juego
    {
        private Pais pais;

        public Juego()
        {
            pais = new Pais(1000, 5000, 80); 
        }
        public void Execute()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Bienvenido al juego de gestion de paises");
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Pasar turno");
                Console.WriteLine("2. Ver estadísticas");
                Console.WriteLine("3. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        pais.PasarTurno();
                        break;
                    case 2:
                        pais.VerEstadisticas();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del juego...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (pais.Felicidad < 20)
                {
                    Console.WriteLine("El juego ha terminado por falta de felicidad.");
                    continuar = false;
                }
            }
        }
    }
}
    

