using System;
using String;

namespace Personajes
{
    public class Personaje
    {
        // Datos
        private String tipo;
        private String name;
        private String apodo;
        private int age;
        private int health;
        // Características
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        
        // Geters and Seters
        public int Velocidad { get => velocidad; set => velocidad; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public iont nivel { get => nivel; set => nivel = value; }
        public String Tipo { get => tipo ; set => tipo = value; }
        public String  Name { get => name; set => name = value }
        public String  Apodo { get => apodo; set => apodo = value}
        public int age { get => ; set => age = value} // se debe considerar TimeSpan para calcular la edad
        public int Health { get => health; set => health = value} //Su seteo depende de acciones o métodos

        // Constructor inicial
        public Personaje(){
            velocidad = 1;
            destreza = 1;
            fuerza = 1;
            nivel = 1;
            age = 15;
            health = 100;
        }

        // Constructor parametrizado
        public Caracteristicas(int velocidad, int destreza, int destreza, int nivel){
            this.velocidad = velocidad;
            this.destreza = destreza;
            this.fuerza = fuerza;
            this.nivel = nivel;
            this.age = age;
            this.health = health;
        }
    }

    public enum TipoPersonaje
    {
        Humano = 0,
        Horco = 1,
        Enano = 2,
        Caballero = 3,
        Elfo = 4,
        Brujo = 5
    }

}