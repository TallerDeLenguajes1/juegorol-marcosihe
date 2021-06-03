using System;
using String;

namespace juegorol_marcosihe
{
    public class Caracteristicas
    {
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;

        public int Velocidad { get => velocidad; set => velocidad; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public iont nivel { get => nivel; set => nivel = value; }

        public Caracteristicas(){
            velocidad = 1;
            destreza = 1;
            fuerza = 1;
            nivel = 1;
        }

        public Caracteristicas(int velocidad, int destreza, int destreza, int nivel){
            this.velocidad = velocidad;
            this.destreza = destreza;
            this.fuerza = fuerza;
            this.nivel = nivel;
        }

        // Métodos relacionados con las características, es decir que las modifican
    }
}