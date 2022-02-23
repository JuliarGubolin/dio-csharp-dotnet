namespace exemplo_construtores.Models
{
    public class Data{
        private int Mes;
        private bool mesValido;
        public int aleatoria 
        { 
            get{
                return this.Mes;
            }
            set{
                if(value > 0 && value <=12){
                    this.Mes = value;
                    this.mesValido = true;
                }
            }
        }
        public int GetMes(){
            return this.Mes;
        }

        public void SetMes(int mes){
            if(mes> 0 && mes <=12){
                this.Mes = mes;
                this.mesValido = true;
            }
        }

        
        public void ApresentarMes(){
            if(this.mesValido){
                System.Console.WriteLine(this.Mes);
            }else{
                System.Console.WriteLine("Mês inválido");
            }
        }
    }
}