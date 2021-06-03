using System;
using String;

namespace juegorol_marcosihe
{
    public class Datos
    {
        private String tipo;
        private String name;
        private String apodo;
        private int age;
        private int health;
        DateTime bornDate = new DateTime(1850,01,13);
        
        public String Tipo { get => tipo ; set => tipo = value; }
        public String  Name { get => name; set => name = value }
        public String  Apodo { get => apodo; set => apodo = value}
        public int age { get => ; set => age = value} // se debe considerar TimeSpan para calcular la edad
        public int Health { get => health; set => health = value} //Su seteo depende de acciones o métodos

        public Datos(){
            
        }

    }
}