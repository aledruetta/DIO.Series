namespace DIO.Series.Model
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public bool Excluido { get; private set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            base.Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public override string ToString()
        {
            return $"[{Id}] {Titulo}, {Descricao}, {Genero}, {Ano}, excluído: {Excluido}";
        }
    }
}