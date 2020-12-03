using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final1
{
    class Proyecto
    {
        private string[] empleados;
        private int[,] sueldos;
        private int[] totalsueldo;

        public void Cargar()
        {
            empleados = new String[6];
            sueldos = new int[6, 4];
            for (int a = 1; a < empleados.Length; a++)
            {
                Console.Write("Ingrese el nombre del empleado  " +a+ " - ");
                empleados[a] = Console.ReadLine();
                for (int b = 1; b < sueldos.GetLength(1); b++)
                {
                    Console.Write("Ingrese sueldo del mes  " +b+  " - ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[a, b] = int.Parse(linea);
                }
            }
        }

        public void SueldoSum()
        {
            totalsueldo = new int[6];
            for (int a = 0; a < sueldos.GetLength(0); a++)
            {
                int suma = 0;
                for (int b = 0; b < sueldos.GetLength(1); b++)
                {
                    suma = suma + sueldos[a, b];
                }
                totalsueldo[a] = suma;
            }
        }

        public void TotSueldos()
        {
            Console.WriteLine("Total de sueldos pagados por empleado=");
            for (int c = 0; c < totalsueldo.Length; c++)
            {
                Console.WriteLine(empleados[c] + " - " + totalsueldo[c]);
            }
        }

        public void SueldoMayor()
        {
            int total = totalsueldo[0];
            string empl = empleados[0];
            for (int d = 0; d < totalsueldo.Length; d++)
            {
                if (totalsueldo[d] > total)
                {
                    total = totalsueldo[d];
                    empl = empleados[d];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es: " + empl + " y tiene un sueldo de: " + total);
        }

        static void Main(string[] args)
        {
            Proyecto x = new Proyecto();
            x.Cargar();
            x.SueldoSum();
            x.TotSueldos();
            x.SueldoMayor();
            Console.ReadKey();
        }
    }
}
