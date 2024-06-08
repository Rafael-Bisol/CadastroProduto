namespace CadastroProduto
{
    public class Produto
    {
        public int Id;
        public string? Nome {get; set;}
        public string? Tipo {get; set;}

        public Produto(int id, string? nome, string? tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }
    }
}