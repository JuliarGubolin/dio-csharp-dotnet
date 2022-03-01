namespace exemplo_poo.Models
{
    public class Retangulo
    {
        private double Comprimento { get; set; }
        private double Largura { get; set; }
        private bool Valido { get; set; }
        public void DefinirMedidas(double Comprimento, double Largura){
            if(Comprimento > 0 && Largura > 0){
                this.Comprimento = Comprimento;
                this.Largura = Largura;
                Valido = true;
            }else{
                System.Console.WriteLine("Valores Inválidos.");
            }
        }
        public double ObterArea(){
            if(Valido){
                return Comprimento * Largura;
            }else{
                System.Console.WriteLine("Preencha valores válidos.");
                return 0;
            }
        }
    }
}