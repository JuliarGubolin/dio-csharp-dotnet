using System;

namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }
        protected void CalcularDistancia(){
            //Ação aqui
            CalcularDistancia2();
        }
        private void CalcularDistancia2(){
            //Ação aqui
        }
        //Virtual: permite que uma classe filha sobrescreva sua ação
        public virtual void CalcularDistancia3(){
            //Ação aqui
        }
    }
}
