using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Autos
    {
        private string fabricante;
        private string modelo;
        private int año;
        private int velocidad;
        private int maniobravilidad;

        public Autos() { }

        public Autos(string fabricante, int año, int velocidad,int maniobravilidad , string modelo)
        {
            this.fabricante = fabricante;
            this.año = año;
            this.maniobravilidad = maniobravilidad;
            this.modelo = modelo;
            this.velocidad = velocidad;

        }

        public void setFabricante(string fabricante) { this.fabricante = fabricante; }
        public string getFabricante () { return this.fabricante; }

        public void setModelo(string modelo) { this.modelo = modelo; }
        public string getModelo() { return this.modelo; }

        public void setAño(int año) { this.año=año; }
        public int getAño() { return this.año; }

        public void setVelocidad(int velocidad) { this.velocidad = velocidad; }
        public int getVelocidad() { return this.velocidad; }

        public void setManiobravilidad(int maniobravilidad) { this.maniobravilidad = maniobravilidad; }
        public int getManuiobravilidad() { return this.maniobravilidad; }


        public string ToString() { return $"el modelo de auto es {this.modelo} y fue fabrivado por {this.fabricante} en el año {this.año}, ademas tiene {this.velocidad}% de velocidad y {this.maniobravilidad}% de maneobravilidad"; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            Autos A1 = new Autos("Nissan", 1999, 60, 90, "Skyline");
            Autos A2 = new Autos("Mazda", 1989, 75, 60, "Miata mx-5");
            Autos A3 = new Autos("Chevrolet", 1968, 90, 50, "Corvette c3");


            Console.WriteLine("Debe elegir uno de los siguientes vehiculos para el juego");
            Console.WriteLine("NUMERO 1");
            Console.WriteLine(A1.ToString());
            Console.WriteLine("NUMERO 2");
            Console.WriteLine(A2.ToString());
            Console.WriteLine("NUMERO 3");
            Console.WriteLine(A3.ToString());
            Console.WriteLine("Ingrese e numero del vehiculo que quiere usar");
            aux = Convert.ToInt32(Console.ReadLine());


            switch (aux)
            {

                case 1:
                    Console.WriteLine("usted eligio " + A1.getModelo());
                    break;

                case 2:
                    Console.WriteLine("usted eligio " + A2.getModelo());
                    break;

                case 3:
                    Console.WriteLine("usted eligio " + A3.getModelo());
                    break;

     

            }
        }
    }
}
