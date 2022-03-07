namespace exemplo_poo.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        //Interface com Implementação. Torna opcional a implementação na classe Calculadora
        int Dividir(int n1, int n2){
            return n1/n2;
        }

    }
}