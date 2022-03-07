namespace exercicio.Model{
    public struct MesDados{
        public int mes { get; set; }
        public double minima { get; set; }
        public double media { get; set; }
        public double maxima { get; set; }
        public int qtdVezes { get; set;}
        public MesDados(int mes, double minima, double media, double maxima, int qtdVezes)
        {
            this.mes = mes;
            this.maxima = maxima;
            this.minima = minima;
            this.media = media;
            this.qtdVezes = qtdVezes;
        }
    }
    
}
