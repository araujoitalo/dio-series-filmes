namespace DIO.Series.Classes
{
    public abstract class EntidadeBase
    {
        
        // Atributos
        public int Id {get; protected set;}

		public Genero Genero { get; set; }

		public string Titulo { get; set; }

		public string Descricao { get; set; }

		public int Ano { get; set; }

        public bool Excluido {get; set;}
    }
}