using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class ReservaNatural
    {
        private string NombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            avistamientos = new int[3, 3];

            Console.WriteLine("Ingrese el nombre de la reserva");
            NombreReserva = Console.ReadLine();

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine("Ingrese cantidad de avistamientos");

                    avistamientos[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string ReturnarNombre()
        {
            return NombreReserva;
        }

        public int ReturnarDato(int f, int c)
        {
            return avistamientos[f, c];
        }
    }

    internal class CentroEcologico
    {
        private ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];

            for (int i = 0; i < 3; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }

        public void TotalAvistamientos()
        {
            for (int g = 0; g < 3; g++)
            {
                int total = 0;

                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        total += reservas[g].ReturnarDato(f, c);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Reserva: " + reservas[g].ReturnarNombre());
                Console.WriteLine("Total de avistamientos: " + total);
            }
        }

        public void MayorAvistamiento()
        {
            int mayor = reservas[0].ReturnarDato(0, 0);

            string reserva = reservas[0].ReturnarNombre();

            int fila = 0;
            int columna = 0;

            for (int g = 0; g < 3; g++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (reservas[g].ReturnarDato(f, c) > mayor)
                        {
                            mayor = reservas[g].ReturnarDato(f, c);
                            reserva = reservas[g].ReturnarNombre();
                            fila = f;
                            columna = c;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Mayor avistamiento:");
            Console.WriteLine("Reserva: " + reserva);
            Console.WriteLine("Coordenada: [" + fila + "," + columna + "]");
            Console.WriteLine("Cantidad: " + mayor);
        }

        static void Main(string[] args)
        {
            CentroEcologico ce = new CentroEcologico();
            ce.TotalAvistamientos();
            ce.MayorAvistamiento();
            Console.ReadKey();
        }
    }
}
