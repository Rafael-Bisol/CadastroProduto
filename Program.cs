namespace CadastroProduto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProdutoController prodControl = new ProdutoController();
            int id = -1;

            int opcao = -1;
            string opcoesMenu = 
                "Cadastro de Produtos\n" +
                "Opções de escolha:\n" +
                "0 - Sair\n" +
                "1 - Criar Produto\n" +
                "2 - Mostrar Produto\n" +
                "3 - Listar todos os produtos\n" +
                "4 - Modificar Protudo\n" +
                "5 - Remover Produto\n" +
                "6 - Limpar tela e ver menu";
            
            System.Console.WriteLine(opcoesMenu);

            do {
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.Write("Digite o nome do produto: ");
                        string? nome = Console.ReadLine();
                        Console.Write("Digite o tipo do produto: ");
                        string? tipo = Console.ReadLine();

                        prodControl.Create(nome, tipo);
                        System.Console.WriteLine("Produto criado!");
                        break;
                    case 2:
                        id = DigiteId();
                        
                        prodControl.Read(id);
                        break;
                    case 3:
                        prodControl.ReadAll();
                        break;
                    case 4:
                        id = DigiteId();

                        prodControl.Update(id);
                        System.Console.WriteLine("Produto atualizado!");
                        break;
                    case 5:
                        id = DigiteId();

                        prodControl.Delete(id);
                        System.Console.WriteLine("Produto excluído!");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(opcoesMenu);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        public static int DigiteId()
        {
            Console.Write("Digite o id do produto: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
    }
}
