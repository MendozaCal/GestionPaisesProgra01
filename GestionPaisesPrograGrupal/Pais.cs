using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPaisesPrograGrupal
{
    internal class Pais
    {
        public int Poblacion { get; set; }
        public float Dinero { get; set; }
        public int Felicidad { get; set; }
        public float TasaImpuestos { get; set; }

        public Salud Salud { get; set; }
        public Educación Educacion { get; set; }
        public Seguridad Seguridad { get; set; }

        public Pais(int poblacionInicial, float dineroInicial, int felicidadInicial)
        {
            Poblacion = poblacionInicial;
            Dinero = dineroInicial;
            Felicidad = felicidadInicial;
            TasaImpuestos = 0.2f;

            Salud = new Salud("Salud", 150, 10);
            Educacion = new Educación("Educación", 100, 10);
            Seguridad = new Seguridad("Seguridad", 200, 10);
        }

        public void PasarTurno()
        {
            Dinero -= Salud.GetPrice() + Educacion.GetPrice() + Seguridad.GetPrice();

            Dinero += Poblacion * TasaImpuestos;

            // Ajustar la población
            if (Salud.GetPrice() > 80)
            {
                Poblacion += (int)(Poblacion * 0.1);
            }
            else
            {
                Poblacion -= (int)(Poblacion * 0.1);
            }

            // Ajustar la felicidad
            if (Seguridad.GetPrice() < 20)
            {
                Felicidad -= 10;
            }

            if (Felicidad < 20)
            {
                Console.WriteLine("El juego ha terminado porque la felicidad es demasiado baja.");
            }
        }

        public void VerEstadisticas()
        {
            Console.WriteLine($"Población: {Poblacion}");
            Console.WriteLine($"Dinero: {Dinero}");
            Console.WriteLine($"Felicidad: {Felicidad}");
        }

        public void AjustarImpuesto(float nuevaTasa)
        {
            TasaImpuestos = nuevaTasa;
        }

        public void AjustarGastoEnServicio(string servicio, float nuevoPrecio)
        {
            switch (servicio.ToLower())
            {
                case "educacion":
                    Educacion.SetPrice(nuevoPrecio);
                    break;
                case "salud":
                    Salud.SetPrice(nuevoPrecio);
                    break;
                case "seguridad":
                    Seguridad.SetPrice(nuevoPrecio);
                    break;
                default:
                    Console.WriteLine("Servicio no válido.");
                    break;
            }
        }
    }
}
