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
             void ModificarGastosOImpuestos()
            {
                Console.WriteLine("Opciones para modificar:");
                Console.WriteLine("1. Ajustar impuestos");
                Console.WriteLine("2. Ajustar gasto en educación");
                Console.WriteLine("3. Ajustar gasto en salud");
                Console.WriteLine("4. Ajustar gasto en seguridad");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese nueva tasa de impuestos (porcentaje, ej.: 0.15 para 15%): ");
                        float nuevaTasa = float.Parse(Console.ReadLine());
                        pais.AjustarImpuesto(nuevaTasa);
                        break;
                    case 2:
                        Console.Write("Ingrese nuevo precio para Educación: ");
                        float nuevoPrecioEducacion = float.Parse(Console.ReadLine());
                        pais.AjustarGastoEnServicio("educacion", nuevoPrecioEducacion);
                        break;
                    case 3:
                        Console.Write("Ingrese nuevo precio para Salud: ");
                        float nuevoPrecioSalud = float.Parse(Console.ReadLine());
                        pais.AjustarGastoEnServicio("salud", nuevoPrecioSalud);
                        break;
                    case 4:
                        Console.Write("Ingrese nuevo precio para Seguridad: ");
                        float nuevoPrecioSeguridad = float.Parse(Console.ReadLine());
                        pais.AjustarGastoEnServicio("seguridad", nuevoPrecioSeguridad);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

    }
}

    

