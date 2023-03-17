using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{   class Personaje
    {
        private int vida;
        private int poder;
        private int velocidad;
        private string nombre;
        private string tipo;


        public Personaje() { }

        public Personaje(string nombre, int vida, int poder, string tipo, int velocidad)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.poder = poder;
            this.tipo = tipo;
            this.velocidad = velocidad;

        }

        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return this.nombre; }

        public void setVida(int  vida) { this.vida = vida; }
        public int getVida() { return this.vida; }

        public void setPoder(int poder) { this.poder = poder; }
        public int getPoder() { return this.poder; }

        public void setTipo(string tipo) { this.tipo = tipo; }
        public string getTipo() { return this.tipo; }

        public void setVelocidad(int velocidad) { this.velocidad = velocidad; }
        public int getVelocidad() { return this.velocidad; }


        public void pantalladeCarga()
        {
            int aux = 0;
            Console.WriteLine("ingrese 1 si quiere descansar y subir su hp");
            Console.WriteLine("ingrese 2 si quiere cargar un hechizo");
            Console.WriteLine("ingrese 3 si quiere atacar a un enemigo");
            aux = Convert.ToInt32(Console.ReadLine());

            switch(aux)
            {

                case 1:
                    this.vida += 5;
                    Console.WriteLine("su vida subio a " + this.vida);
                    break;

                case 2:

                    Console.WriteLine("estas cargando un hechizo");
                    break;


                case 3:
                    Console.WriteLine("golpeaste a un enemigo con tu poder de: " + poder);
                    break;
            }
        }

        public string ToString() { return $"el persobaje tiene de nombre {this.nombre} ,de vida {this.vida} y tiene un poder de {this.poder}, ademas tiene una velocidad de {this.velocidad} ademas tiene una velocidad de {this.velocidad}"; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Personaje A1 = new Personaje("Felipe", 10, 5, "Cazador", 7);
           Console.WriteLine( A1.ToString());
            A1.pantalladeCarga();






        }
    }
}
