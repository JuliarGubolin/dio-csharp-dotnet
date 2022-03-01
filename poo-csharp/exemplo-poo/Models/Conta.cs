namespace exemplo_poo.Models{
    public abstract class Conta{
        //Somente a própria classe e as classes filhas podem acessar protected
        protected double saldo;
        //Quando é abstrado, o método NÃO permite implementações
        public abstract void Creditar(double valor);
        public void ExibirSaldo(){
            System.Console.WriteLine($"Seu saldo é: {saldo}.");
        }
    }
}