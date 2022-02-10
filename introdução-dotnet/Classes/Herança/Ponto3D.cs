using System;

namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        private int distancia;

        public Ponto3D(int x, int y, int z) : base(x,y){
            this.z=z;
            CalcularDistancia();
        }

        //Não pertence a instância, pertence a classe
        public static void Calcular(){
            //Ação aqui
        }
        public override void CalcularDistancia3(){
            //Ação aqui
        }
    }
}
