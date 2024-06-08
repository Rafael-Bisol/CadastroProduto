namespace CadastroProduto
{
    public class ProdutoController
    {
        private List<Produto> produtos;

        public ProdutoController()
        {
            produtos = new List<Produto>();
        }

        public int FindProductId(int id)
        {
            if (produtos.Count == 0){
                return -1;
            }
            for (int i = 0; i < produtos.Count; i++) {
                if (produtos[i].Id == id) {
                    return i;
                }
            }
            return -1;
        }

        public void Create(string nome, string tipo)
        {
            int newId = 0;
            if (produtos.Count > 0) {
                newId = produtos[produtos.Count - 1].Id + 1;
            } else if (produtos.Count < 0) {
                Console.WriteLine("Erro desconhecido.");
            }
            Produto produto = new Produto(newId, nome, tipo);
            produtos.Add(produto);
        }

        public void Read(int id)
        {
            int index = FindProductId(id);
            if (index == -1) {
                Console.WriteLine("Produto não encontrado!");
                return;
            }
            Console.WriteLine($"Nome do produto: {produtos[index].Nome}\n" +
                                $"Tipo do produto: {produtos[index].Tipo}");
        }

        public void Update(int id)
        {
            int index = FindProductId(id);
            if (index == -1){
                Console.WriteLine("Produto naõ encontrado!");
                return;
            }
            Console.Write("Digite o novo nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Digite o novo tipo: ");
            string? tipo = Console.ReadLine();

            produtos[index].Nome = nome;
            produtos[index].Tipo = tipo;
            Console.WriteLine("Produto atualizado!");
        }

        public void Delete(int id)
        {
            int index = FindProductId(id);
            if (index == -1) {
                Console.WriteLine("Produto não encontrado!");
            }
            produtos.RemoveAt(index);
        }
    }
}