using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_crud
{
    class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
}

class Program
{
        static List<Pessoa> listaPessoas = new List<Pessoa>();
        static int ultimoId = 0;

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Inserir nova pessoa");
                Console.WriteLine("2 - Exibir todas as pessoas cadastradas");
                Console.WriteLine("3 - Atualizar dados de uma pessoa");
                Console.WriteLine("4 - Excluir uma pessoa");
                Console.WriteLine("5 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirPessoa();
                        break;
                    case 2:
                        ExibirPessoas();
                        break;
                    case 3:
                        AtualizarPessoa();
                        break;
                    case 4:
                        ExcluirPessoa();
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void InserirPessoa()
        {
            Console.Clear();
            Console.WriteLine("Inserir nova pessoa:");

            Pessoa pessoa = new Pessoa();

            pessoa.Id = ++ultimoId;

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            pessoa.Telefone = Console.ReadLine();

            listaPessoas.Add(pessoa);

            Console.WriteLine("Pessoa inserida com sucesso!");
        }

        static void ExibirPessoas()
        {
            Console.Clear();
            Console.WriteLine("Pessoas cadastradas:");

            foreach (Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine("{0} - {1} - {2}", pessoa.Id, pessoa.Nome, pessoa.Telefone);
            }
        }

        static void AtualizarPessoa()
        {
            Console.Clear();
            Console.WriteLine("Atualizar dados de uma pessoa:");

            Console.Write("ID da pessoa: ");
            int id = int.Parse(Console.ReadLine());

            Pessoa pessoa = listaPessoas.Find(p => p.Id == id);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
            else
            {
                Console.Write("Nome ({0}): ", pessoa.Nome);
                string nome = Console.ReadLine();

                Console.Write("Telefone ({0}): ", pessoa.Telefone);
                string telefone = Console.ReadLine();

                if (!string.IsNullOrEmpty(nome))
                {
                    pessoa.Nome = nome;
                }

                if (!string.IsNullOrEmpty(telefone))
                {
                    pessoa.Telefone = telefone;
                }

                Console.WriteLine("Pessoa atualizada com sucesso!");
            }
        }

        static void ExcluirPessoa()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma pessoa:");

            Console.Write("ID da pessoa: ");
            int id = int.Parse(Console.ReadLine());

            Pessoa pessoa = listaPessoas.Find(p => p.Id == id);

            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
            else
            {
                listaPessoas.Remove(pessoa);

                Console.WriteLine("Pessoa excluída com sucesso!");
            }
        }
    }
}