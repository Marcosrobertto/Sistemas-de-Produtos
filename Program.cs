using System;

namespace Sistema_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
                        // Variáveis
            bool promocao;
            int escolha;
            int contador = 0;
            string resposta;
            float desconto;
            float totalPagar;


            // Dados do produto
            string[] nomes = new string[10];
            float[] preco = new float[10];


            Console.WriteLine("-------------------------");
            Console.WriteLine("---Sistema de Produtos---");
            Console.WriteLine("-------------------------");

            // Menu
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Seleciona uma opção a baixo");
                Console.WriteLine("[1] - Cadastrar Produto");
                Console.WriteLine("[2] - Listar Peodutos");
                Console.WriteLine("[0] - Mostrar Menu");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro Produto");
                        do
                        {
                            if (contador <10){
                                Console.WriteLine($"Digite o nome do {contador+1}° produto:");
                                nomes[contador] = Console.ReadLine();
                                Console.WriteLine("Digite o preço do produto:");
                                preco[contador] = float.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Tem promoção nesse produto? ");
                                promocao = promo(preco[contador]);



                                contador++;
                            }else{
                                Console.WriteLine("Você chegou no Limite.");
                                break;
                            }
                            Console.WriteLine("Você gostaria de casdastrar um novo produto? s/n");
                            resposta = Console.ReadLine();

                        } while (resposta.ToUpper() == "S");
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Listar Produtos");
                        for (int i = 0; i < contador; i++){
                            Console.WriteLine($"Produto {nomes[i]}, Preço: {preco[i]}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por acessar");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }


            } while (true);

            // Funções
            bool promo (float preco) {
                if (preco > 6.00){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Produto com promoção.");
                    Console.ResetColor();
                    desconto = preco * 0.05f;
                    totalPagar = preco - desconto;
                    Console.WriteLine("Você ganhou um desconto de 5% irá pagar: "+ totalPagar);

                    return true;
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Produto sem promoção");
                    Console.ResetColor();
                    return false;
                }
            }
        }
    }
}
