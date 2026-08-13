using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_
{
    /*
        Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
        vinculados a una red hogareña.
         Crear la clase DispositivoInteligente que contenga como atributos
        privados: nombreDispositivo (string) y consumoWatts (double). Definir
        sus propiedades y un constructor que reciba nom y watts.
         Crear la clase colaboradora PanelDomotico que administre un objeto
        List&lt;DispositivoInteligente&gt;.
         Métodos en PanelDomotico:
        1. Un constructor que permita al usuario cargar dinámicamente
        dispositivos por teclado. El sistema preguntará después de cada
        carga si se desea agregar otro dispositivo.
        2. MostrarDispositivos(): Listar todos los dispositivos
        configurados junto a sus consumos.
        3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
        Watts totales que consume la casa sumando los valores de la lista.
        4. DesconectarDispositivo(): Solicitar al usuario el nombre de
        un dispositivo y, si existe en la lista, removerlo de forma dinámica
        para simular su apagado remoto.
     */
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;
        
        public string NombreDispositivo
        {
            set
            {
                nombreDispositivo = value;
            }
            get
            {
                return nombreDispositivo;
            }
        }
        public double ConsumoWatts
        {
            set
            {
                consumoWatts = value;
            }
            get
            {
                return consumoWatts;
            }
        }

        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }
    internal class PanelDomotico
    {
        List<DispositivoInteligente> DispositivoInt = new List<DispositivoInteligente>();
        
        public PanelDomotico() 
        {
            String respuesta;
            do
            {
                Console.Write("Ingrese el nombre del dispositivo: ");
                string nom = Console.ReadLine();

                Console.Write("Ingrese el consumo de Watts del dispositivo: ");
                double watts = double.Parse(Console.ReadLine());
                
                DispositivoInteligente dispositivo = new DispositivoInteligente(nom, watts);

                DispositivoInt.Add(dispositivo);
                Console.WriteLine();

                Console.WriteLine("Desea agregar un dispositivo mas?(s/n): ");
                respuesta = Console.ReadLine();
                Console.WriteLine();
            } 
            while (respuesta.ToLower() == "s");
        }
        public void MostrarDispositivos()
        {
            Console.WriteLine("=== MOSTRANDO LISTA DE DISPOSITIVOS ===");
            foreach (DispositivoInteligente DI in DispositivoInt)
            {
                Console.WriteLine($"Nombre del dispositivo: {DI.NombreDispositivo} y consume: {DI.ConsumoWatts}W");
            }
        }
        public void CalcularConsumoTotal()
        {
            double totalwatts = 0;

            for (int i = 0; i < DispositivoInt.Count; i++)
            {
                totalwatts += DispositivoInt[i].ConsumoWatts;
            }

            Console.WriteLine($"La cantidad total de watts que consume la casa es de: {totalwatts}");
        }
        public void DesconectarDispositivo()
        {
            Console.Write("Ingrese el nombre del dispositivo que quiere desconectar: ");
            string nom = Console.ReadLine();

            DispositivoInteligente dispositivoEncontrado = null;

            foreach (DispositivoInteligente dispositivo in DispositivoInt)
            {
                if (dispositivo.NombreDispositivo == nom)
                {
                    dispositivoEncontrado = dispositivo;
                    break;
                }
            }

            if (dispositivoEncontrado != null)
            {
                DispositivoInt.Remove(dispositivoEncontrado);
                Console.WriteLine("El dispositivo fue desconectado correctamente.");
            }
            else
            {
                Console.WriteLine("El dispositivo no fue encontrado.");
            }
        }
        static void Main(string[] args)
        {
            PanelDomotico PD = new PanelDomotico();
            PD.MostrarDispositivos();
            PD.CalcularConsumoTotal();
            PD.DesconectarDispositivo();
            Console.ReadKey();
        }
    }
}
