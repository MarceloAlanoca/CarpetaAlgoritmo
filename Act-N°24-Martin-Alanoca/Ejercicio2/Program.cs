using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /*
        Una farmacia controla el nivel de stock de sus medicamentos para evitar el
        desabastecimiento de insumos esenciales.
         Crear la clase Medicamento que contenga los atributos privados: nombre
        (string) y stock (int). Definir sus propiedades correspondientes. Su
        constructor debe recibir nom y stk.
         Crear la clase ControlFarmacia que administre una lista de objetos List.
         Métodos en ControlFarmacia:
        o Un constructor que cargue por teclado una lista inicial de 4
        medicamentos ingresando sus nombres y stock.
        o ListarStock(): Mostrar la lista de medicamentos en pantalla.

        o RemoverAgotados(): Recorrer la lista y remover por completo de
        la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
        o MostrarMedicamentosDisponibles(): Imprimir la lista
        actualizada y la cantidad de productos disponibles en el inventario
        utilizando la propiedad .Count.
     */
    class Medicamento
    {
        private string nombre;
        private int stock;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }
        public Medicamento(string nom, int sto)
        {
            nombre = nom;
            stock = sto;
        }
    }
    internal class ControlFarmacia
    {
        List<Medicamento> ListMedicamento = new List<Medicamento>(); 
        public ControlFarmacia()
        {
            for (int i = 0; i < 4; i++) 
            {
                Console.Write("Ingrese el nombre del medicamente: ");
                string nom = Console.ReadLine();

                Console.Write("Ingrese la cantidad de stock del producto: ");
                int stock = int.Parse(Console.ReadLine());

                Medicamento Medicina = new Medicamento(nom, stock);

                ListMedicamento.Add(Medicina);
                Console.WriteLine();
            }
        }
        public void ListarStock()
        {
            Console.WriteLine("=== CARGANDO LA LISTA DE MEDICAMENTOS ===");
            Console.WriteLine();
            foreach (Medicamento Med in ListMedicamento)
            {
                Console.WriteLine($"Nombre del medicamente: {Med.Nombre} \n Cantidad en el Stock: {Med.Stock}");
                Console.WriteLine();
            }
        }
        public void RemoverAgotados()
        {
            for(int i = ListMedicamento.Count - 1; i >= 0 ; i--)
            {
                if (ListMedicamento[i].Stock == 0)
                {
                    ListMedicamento.RemoveAt(i);
                }
            }
        }
        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("=== MOSTRANDO LOS MEDICAMENTOS DISPONIBLES ===");
            Console.WriteLine();
            for (int i = 0; i < ListMedicamento.Count; i++)
            {
                Console.WriteLine($"Nombre del medicamente: {ListMedicamento[i].Nombre} \n Cantidad en el Stock: {ListMedicamento[i].Stock}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ControlFarmacia CF = new ControlFarmacia();
            CF.ListarStock();
            CF.RemoverAgotados();
            CF.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}
