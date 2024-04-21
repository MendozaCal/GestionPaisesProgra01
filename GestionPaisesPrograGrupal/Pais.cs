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

            
            Poblacion += Salud.GetVariationSalud();

            
            Felicidad += Seguridad.GetVariationSeguridad();

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
    }
}
