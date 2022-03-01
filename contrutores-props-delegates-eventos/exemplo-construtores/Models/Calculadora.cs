namespace exemplo_construtores.Models{
    public class Calculadora{

        //Delegate
        public delegate void DelegateCalculadora();
        //Evento
        public static event DelegateCalculadora EventoCalculadora;

        public static void somar(int x, int y){
            if(EventoCalculadora != null){
                System.Console.WriteLine($"Adição: {x+y}");
                EventoCalculadora();
            }else{
                System.Console.WriteLine($"Nenhum inscrito.");
            }
        }
        public static void subtrair(int x, int y){
            System.Console.WriteLine($"Subtração: {x-y}");
        }
    }
}