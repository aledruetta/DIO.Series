namespace DIO.Series.Entities
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get; protected set; }
        public string Titulo { get; protected set; }
        public string Descricao { get; protected set; }
        public int Ano { get; protected set; }
        private bool _excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            base.Id = Id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            _excluido = false;
        }

        public void Excluir()
        {
            _excluido = true;
        }

        public override string ToString()
        {
            return $"[{Id}] {Genero}, {Titulo}, {Descricao}, {Ano}";
        }
    }
}